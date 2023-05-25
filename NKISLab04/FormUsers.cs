using System.Data.Common;
//using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NKISLab04
{
    public partial class FormUsers : Form
    {
        // права (Rights) на чтение / изменение данных - битовые маски
        const int R_1r = 0b00000001;        // на чтение открытых данных
        const int R_2r = 0b00000010;        // на чтение защищенных данных
        const int R_1w = 0b00000100;        // на изменение открытых данных
        const int R_2w = 0b00001000;        // на изменение защищенных данных

        const int R_a = 0b00010000;     // право на добавление записей
        const int R_d = 0b00100000;     // право на удаление записей

        //  группы прав
        static int[] groups = { 0                               // 0 - никаких прав нет
                    , R_1r | R_2r | R_1w | R_2w | R_a | R_d    // 1 - Директор
                    , R_1r | R_2r | R_1w | R_2w              // 2 - Зам
                    , R_1r | R_2r                            // 3 - Секретарь
                    , R_1r                                   // 4 - Остальные
                    };

        static string[] fields =
        {"ID","Фамилия","Имя","Отчество","Должность","Тел.","Адрес","Дом.тел.","Группа","Пароль"};
        static int[] fieldType = { 1, 1, 1, 1, 1, 1, 2, 2, 1, 2 }; // типы полей:   1-открытые данные,

        static String connString = "Server=localhost" + ";Database=dev"
                            + ";port=3306" + ";User Id=dev" + ";password=userdev";
        static MySqlConnection conn = new MySqlConnection(connString);
        static MySqlCommand cmd = new MySqlCommand();
        static string sql = "";
        DbDataReader reader;
        bool loginOK = false;
        int groupThis = 0;      // еще не входили
        bool readerReading = false;
        string readerLastKey = "";

        public FormUsers()
        {
            InitializeComponent();
            conn.Open();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            groupThis = 4;
            //MessageBox.Show(tbUserThis.Text + "/" + tbPasswordThis.Text);
            if (tbUserThis.Text == "")
            {
                groupThis = 4;
                loginOK = true;
            }
            else
            {
                sql = "Select Gr from users where user = '" + tbUserThis.Text +
                    "' and password = '" + tbPasswordThis.Text + "'";
                //MessageBox.Show(sql);

                cmd = new MySqlCommand();   // Создать объект Command
                cmd.Connection = conn;      // Связать Command с Connection
                cmd.CommandText = sql;
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    groupThis = Convert.ToInt32(reader.GetString(0));
                    loginOK = true;
                }
                else
                { 
                    MessageBox.Show("Неправильные Пользователь или Пароль");
                }
                reader.Close();
            }
            if (!loginOK) return;

            btLogin.Visible = false;
            btToFirst.Enabled = true;
            btNext.Enabled = true;
            btDel.Enabled = true;
            btAdd.Enabled = true;
            btSave.Enabled = true;
            btCancel.Enabled = true;

            tbUserThis.ReadOnly = true;
            tbPasswordThis.ReadOnly = true;

            tbUser.ReadOnly = true;
            tbF.ReadOnly = ((groups[groupThis] & R_1w) == 0);
            tbI.ReadOnly = tbF.ReadOnly;
            tbO.ReadOnly = tbF.ReadOnly;
            tbPosition.ReadOnly = tbF.ReadOnly;
            tbWorkPh.ReadOnly = tbF.ReadOnly;

            tbHomeAdr.ReadOnly = ((groups[groupThis] & R_2w) == 0);
            tbHomePh.ReadOnly = tbHomeAdr.ReadOnly;
            cbGroup.Enabled = ((groups[groupThis] & R_2w) != 0);
            tbPassword.ReadOnly = tbHomeAdr.ReadOnly;

            tbHomeAdr.Visible = ((groups[groupThis] & R_2r) != 0);
            tbHomePh.Visible = tbHomeAdr.Visible;
            tbPassword.Visible = tbHomeAdr.Visible;

            btSave.Visible = ((groups[groupThis] & (R_2w | R_1w)) != 0);
            btCancel.Visible = btSave.Visible;

            btDel.Visible = ((groups[groupThis] & R_d) != 0);
            btAdd.Visible = ((groups[groupThis] & R_a) != 0);

            NewRead();
        }

        private void NewRead()
        {
            sql = "Select * from users where user >= '" + readerLastKey + "' order by user";
            readerLastKey = "";
            cmd = new MySqlCommand();   // Создать объект Command
            cmd.Connection = conn;      // Связать Command с Connection
            cmd.CommandText = sql;
            if (readerReading) reader.Close();
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                readerReading = true;
                if (reader.Read())
                {
                    fillForm();
                }
                else
                {
                    readerReading = false;
                    reader.Close();
                }
            }

        }

        private void fillForm()
        {
                string s;
            s = readerReading ? reader.GetString(0) : ""; tbUser.Text = s;
            s = readerReading ? reader.GetString(1) : ""; tbF.Text = s;
            s = readerReading ? reader.GetString(2) : ""; tbI.Text = s;
            s = readerReading ? reader.GetString(3) : ""; tbO.Text = s;
            s = readerReading ? reader.GetString(4) : ""; tbPosition.Text = s;
            s = readerReading ? reader.GetString(5) : ""; tbWorkPh.Text = s;
            s = readerReading ? reader.GetString(6) : ""; tbHomeAdr.Text = s;
            s = readerReading ? reader.GetString(7) : ""; tbHomePh.Text = s;
            s = readerReading ? reader.GetString(8) : ""; cbGroup.Text = s;
            s = readerReading ? reader.GetString(9) : ""; tbPassword.Text = s;
              //MessageBox.Show(tbUser.Text + tbF.Text + s + tbI.Text);
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (readerReading)
            {
                if (!reader.Read())         // взять следующую запись
                {
                    readerReading = false;
                    reader.Close();
                }
                fillForm();
            }
            else
            {
                MessageBox.Show("Достигнут конец записей, переход в начало");
                btToFirst_Click(sender, e);
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (tbUser.Text == "") return;
            if (! readerReading) return;
            
            readerLastKey = tbUser.Text;        // сохранили позицию где находимся
            readerReading = false;
            reader.Close();

            try
            {
                sql = "Delete from users where user = '" + tbUser.Text + "'";
                MessageBox.Show(sql);

                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;

                int rowCount = cmd.ExecuteNonQuery();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error: " + ee.Message);
            }
            NewRead();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            tbUser.ReadOnly = false;
            btAdd.Enabled = false;
        }

        private void btSave_Click(object sender, EventArgs e)
        {   
          if (tbUser.Text.Trim() == "") return;   // пустая форма
            if (btAdd.Enabled)                  // Сохранить в режиме редактирования
            {
                if (readerReading)
                {
                    readerLastKey = tbUser.Text;        // сохранили позицию где находимся
                    readerReading = false;
                    reader.Close();

                    try
                    {
                        sql = "Update users set " +
                            "F = '" + tbF.Text + "' " +
                            ", I = '" + tbI.Text + "' " +
                            ", O = '" + tbO.Text + "' " +
                            ", Position = '" + tbPosition.Text + "' " +
                            ", WorkPh = '" + tbWorkPh.Text + "' " +
                            ", HomeAdr = '" + tbHomeAdr.Text + "' " +
                            ", HomePh = '" + tbHomePh.Text + "' " +
                            ", Gr = '" + cbGroup.Text + "' " +
                            ", Password = '" + tbPassword.Text + "' " +
                            "  where user = '" + tbUser.Text + "'";
                        //MessageBox.Show(sql);

                        cmd = new MySqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = sql;

                        int rowCount = cmd.ExecuteNonQuery();
                        if (rowCount == 0) MessageBox.Show("Изменения не прошли");
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show("Error: " + ee.Message);
                    }
                }
            }
            else
            {                           // Сохранить в режиме вставки
                readerLastKey = tbUser.Text;        // сохранили позицию где находимся
                readerReading = false;
                reader.Close();
                try
                {
                    sql = "Insert into users " +
                    "(`user`, `F`, `I`, `O`, `Position`, `WorkPh`, `HomeAdr`, `HomePh`, `Gr`, `Password`) " +
                    "VALUES ('" + tbUser.Text + "'" +
                        ", '" + tbF.Text + "' " +
                        ", '" + tbI.Text + "' " +
                        ", '" + tbO.Text + "' " +
                        ", '" + tbPosition.Text + "' " +
                        ", '" + tbWorkPh.Text + "' " +
                        ", '" + tbHomeAdr.Text + "' " +
                        ", '" + tbHomePh.Text + "' " +
                        ", '" + cbGroup.Text + "' " +
                        ", '" + tbPassword.Text + "' " +
                        ")";
                    MessageBox.Show(sql);

                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = sql;

                    int rowCount = cmd.ExecuteNonQuery();
                    if (rowCount == 0) MessageBox.Show("Добавление записи не прошло");
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Error: " + ee.Message);
                }
            }
            tbUser.ReadOnly = true;
            btAdd.Enabled = true;

            NewRead();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            tbUser.ReadOnly = true;
            btAdd.Enabled = true;
            fillForm();
        }

        private void btToFirst_Click(object sender, EventArgs e)
        {
            NewRead();
        }
    }
}
