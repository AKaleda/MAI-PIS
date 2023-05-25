using System;
using System.Windows.Forms;
using System.Timers;
using System.Media;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace NKISLab02
{
    public partial class Form1 : Form
    {
        const int nx = 21;                  // количество точек графика
        const int nSelectedMax = 100;       // максимально допустимое количество выборочных точек 

        static Random rand = new System.Random();

        static double[] x = new double[nx]; // массивы для графика
        static double[] y1 = new double[nx];
        static double[] y2 = new double[nx];

        static int millisStep;              // шаг таймера (миллисекунды)
        static double tStep;                // этот шаг в секундах
        static double tRelative;            // время (сек), прошедшее от пуска

        static bool firstStart = true;      // признак первого пуска
        static bool newData = false;        // признак, что появилось новое значение
        static double y1New;                // это новое значение


        static int nShow;                   // количество точек в дополнение к текущей для показа в таблице
        //static double[] y1Show;             // для показа в таблице

        static double yMax;                 // значения для контроля
        static double yMin;
        static double yKratno;

        static double yDeltaMax;            // Контроль изменения на одном шаге

        static double[] xS = new double[nSelectedMax];  // массив выборочных точек: относительное время
        static double[] y1S = new double[nSelectedMax]; // значение
        static string[] xwS = new string[nSelectedMax]; // причина попадания
        int nSelected = 0;                              // текущее количество

        static System.Timers.Timer aTimer;              // таймер 


        public Form1()                                  // конструктор Form1()
        {
            InitializeComponent();

            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "{0:0.0}";
            chart1.ChartAreas[0].AxisY2.LabelStyle.Format = "{0:0.0}";
        }

        private void btStart_Click(object sender, EventArgs e)  // нажата кнопка btStart
        {
            btReview.Enabled = true;
            btReview.Select();              // переключение фокуса на кнопку btReview (Анализ),
                      // чтобы при автоматическом вызове от таймера срабатывала кнопка btReview

            if (btStart.Text == "Стоп")     // если на кнопке был текст Стоп, 
            {
                aTimer.Stop();              // то выполненне приостановить

                btStart.Text = "Продолжить"; // на кнопку новый текст
                nudProc.Enabled = true;
                cbMax.Enabled = true;       // разблокировать выбор условий выборочных данных
                cbMin.Enabled = true;
                cbKratno.Enabled = true;

                if (cbMax.Checked) nudMax.Enabled = true;
                if (cbMin.Checked) nudMin.Enabled = true;
                if (cbKratno.Checked) nudKratno.Enabled = true;

                return;
            }
                                            // если на кнопке был текст не Стоп 
            btStart.Text = "Стоп";          // на кнопку текст Стоп

            if (!firstStart)               // если программа уже выполнялась
            {
                nudProc.Enabled = false;
                cbMax.Enabled = false;      // заблокирвать выбор условий выборочных данных
                cbMin.Enabled = false;
                cbKratno.Enabled = false;

                nudMax.Enabled = false;
                nudMin.Enabled = false;
                nudKratno.Enabled = false;

                aTimer.Start();             // выполненне продолжить
                return;
            }
                                            // первый пуск
            nudStep.Enabled = false;
            nudN.Enabled = false;
            nudProc.Enabled = false;

            cbMax.Enabled = false;
            cbMin.Enabled = false;
            cbKratno.Enabled = false;

            nudMax.Enabled = false;
            nudMin.Enabled = false;
            nudKratno.Enabled=false;

            tStep = (double)nudStep.Value;
            millisStep = (int)(tStep * 1000.0);
            nShow = (int)nudN.Value;
            //y1Show = new double[nShow+1];

            yMax = (double)nudMax.Value;
            yMin = (double)nudMin.Value;
            yKratno = (double)nudKratno.Value;
            yDeltaMax = (double)nudProc.Value / 100.0;

            x[nx - 1] = 0;          // занесение времени от 0 в минус с шагом -tStep
            for (int i = nx - 2; i >= 0; i--)
            {
                x[i] = x[i + 1] - tStep;
            }
                                    // Настраиваем оси графика
            chart1.ChartAreas[0].AxisX.Minimum = x[0];
            chart1.ChartAreas[0].AxisX.Maximum = x[nx - 1];
            chart1.ChartAreas[0].AxisY.Maximum = 1;         // эти 0, 1 временно
            chart1.ChartAreas[0].AxisY.Minimum = 0;         // в процессе скорректируем по данным

            // Определяем шаг сетки
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = tStep;

            tRelative = 0;          // устанавливаем 0 относительного времени

            aTimer = new System.Timers.Timer(millisStep); // milliseconds
            aTimer.Elapsed += OnTimedEvent;         // подключаем обработчик событий
            aTimer.AutoReset = true;                // будут повторяющиеся события
            aTimer.Enabled = true;                  // стартуем таймер
            aTimer.Start();
        }

        private void cbMax_CheckedChanged(object sender, EventArgs e)
        {
            nudMax.Enabled = cbMax.Checked ? true : false;  
        }

        private void cbMin_CheckedChanged(object sender, EventArgs e)
        {
            nudMin.Enabled = cbMin.Checked ? true : false;
        }

        private void cbKratno_CheckedChanged(object sender, EventArgs e)
        {
            nudKratno.Enabled = cbKratno.Checked ? true : false;
        }

        private void nudProc_ValueChanged(object sender, EventArgs e)
        {
            yDeltaMax = (double)nudProc.Value / 100.0;
        }

        private void nudMax_ValueChanged(object sender, EventArgs e)
        {
            yMax = (double)nudMax.Value;
        }

        private void nudMin_ValueChanged(object sender, EventArgs e)
        {
            yMin = (double)nudMin.Value;
        }

        private void nudKratno_ValueChanged(object sender, EventArgs e)
        {
            yKratno = (double)nudKratno.Value;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {                                           //выполняется в параллельном потоке (thread)
            //tNow = DateTimeOffset.Now.ToString();
            tRelative += tStep;
            y1New = 3.0 + Math.Sin(tRelative);      // имитация прихода данных (1 значения)
            y1New += (rand.NextDouble()-0.5)*0.5;
            newData = true;
            SendKeys.SendWait("{ENTER}");  // сигнал Enter в основной поток на кнопку Анализ
        }

        private void btReview_Click(object sender, EventArgs e)
        {
            if (!newData) return;   // игнорирование нажатия кнопки Анализ не по сигналу от таймера

            newData = false;        // данные приняты
            tbTime.Text = DateTimeOffset.Now.ToString().Substring(0,19) +  // занесения текущих даты и времени
                string.Format(" t Отн. {0:0.0}",tRelative);

            if (firstStart)
                for (int i = 0; i <= nx - 1; i++) y1[i] = y1New;  // заполнение одинаковыми значениями
            else
            {
                for (int i = 0; i <= nx - 2; i++) y1[i] = y1[i + 1]; // сдвиг данных на одну позицию влево
                y1[nx - 1] = y1New;
            }

            double y1Sum = 0.0;
            for (int i = 0; i < nx; i++) y1Sum+=y1[i];
            y1Sum /= (float)nx;
            for (int i = 0; i < nx; i++) y2[i]=y1Sum;

            if (chart1.ChartAreas[0].AxisY.Maximum < y1New)         // автоматическая настройка оси Y
                chart1.ChartAreas[0].AxisY.Maximum = y1New;
            if (chart1.ChartAreas[0].AxisY.Minimum > y1New)
                chart1.ChartAreas[0].AxisY.Minimum = y1New;

            chart1.Series[0].Points.DataBindXY(x, y1);      // вывод графика
            chart1.Series[1].Points.DataBindXY(x, y2);      // вывод графика

            string s;
            string[] rowY;

            if (firstStart)                             // если первый раз
            {
                s = string.Format("{0:0.000}", y1New);
                for (int i=0; i< (nShow+1); i++)        // добавление в таблицу dgvLasts nShow+1 строк
                {
                    rowY = new string[] { string.Format("{0:0.0}", x[nx - 1 - i]), s };
                    dgvLasts.Rows.Add(rowY);
                }
            }
            else
            {
                for (int i = 0; i < (nShow + 1); i++)
                {
                    s = string.Format("{0:0.000}", y1[nx - 1 - i]);
                    dgvLasts.Rows[i].Cells[1].Value = s;    // в противном случае, занесение новых Y
                }

            }

            string whySelected = "";                 // причина занесения y1New в выборочные данные
            bool yOutOfRange = false;

            if (Math.Abs(y1New - y1[nx - 2]) > Math.Abs(y1[nx - 2]) * yDeltaMax)
            {
                whySelected = "%> " + string.Format("{0:0}%", yDeltaMax * 100);
            }

            if (cbMax.Checked & y1New > yMax)
            {
                whySelected = "> " + string.Format("{0:0.000}", yMax);
                yOutOfRange = true;
            }
            
            if (cbMin.Checked & y1New < yMin)
            {
                whySelected = "< " + string.Format("{0:0.000}", yMin);
                yOutOfRange = true;
            }
            if (cbKratno.Checked & y1New >= yKratno * 2.0)
            {
                whySelected = ">> " + string.Format("{0:0.000}", yKratno);
                yOutOfRange = true;
            }

            if (whySelected != "")          // причина есть
            {
                if (nSelected < nSelectedMax)
                {
                    nSelected++;
                    rowY = new string[] { "","","" };  // добавить пустую строку, ниже она будет заполнена
                    dgvSelected.Rows.Add(rowY);
                }
                for (int i= nSelected-1; i >= 1; i--)
                {                           // сдвиг всех строк на 1 вниз. Если в начале было 
                                            // nSelected == nSelectedMax, то последняя строка потеряется
                    xS[i] = xS[i - 1];
                    y1S[i] = y1S[i - 1];
                    xwS[i] = xwS[i - 1];
                    dgvSelected.Rows[i].Cells[0].Value = dgvSelected.Rows[i - 1].Cells[0].Value;
                    dgvSelected.Rows[i].Cells[1].Value = dgvSelected.Rows[i-1].Cells[1].Value;
                    dgvSelected.Rows[i].Cells[2].Value = dgvSelected.Rows[i-1].Cells[2].Value;
                    dgvSelected.Rows[i].DefaultCellStyle.BackColor = 
                        dgvSelected.Rows[i - 1].DefaultCellStyle.BackColor;
                }
                xS[0] = tRelative;          // новая первая строка
                y1S[0] = y1New;
                xwS[0] = whySelected;

                dgvSelected.Rows[0].Cells[0].Value = string.Format("{0:0.0}", xS[0]);
                dgvSelected.Rows[0].Cells[1].Value = string.Format("{0:0.000}", y1S[0]);
                dgvSelected.Rows[0].Cells[2].Value = xwS[0];

                if (yOutOfRange)
                {
                    dgvSelected.Rows[0].DefaultCellStyle.BackColor = Color.Yellow;
                    SystemSounds.Hand.Play();
                }
                else 
                {
                    dgvSelected.Rows[0].DefaultCellStyle.BackColor = Color.LightYellow;
                    SystemSounds.Beep.Play();
                }
            }

            chart2.Series[0].Points.Clear();

            for (int k = 0; k < nSelected; k++)
            {
                chart2.Series[0].Points.AddXY(y1S[k], 1);
            }

            //chart2.ChartAreas[0].AxisX.Minimum = chart1.ChartAreas[0].AxisY.Minimum;
            //chart2.ChartAreas[0].AxisX.Maximum = chart1.ChartAreas[0].AxisY.Maximum;
            chart2.ChartAreas[0].AxisX.LabelStyle.Format = "{0:0.0}";

            chart2.DataManipulator.Sort(PointSortOrder.Ascending, "X", "Выб. данные");
            chart2.DataManipulator.Group("Sum", 0.2, IntervalType.Number, "Выб. данные");

            firstStart = false;
        }
    }
}
