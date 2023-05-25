//      Проект -> Добавить ссылку на проект -> Обзор
//      C:\Program Files (x86)\MySQL\Connector NET 8.0\Assemblies\net6.0 MySql.Data.dll
namespace NKISLab04
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormUsers());
        }
    }
}