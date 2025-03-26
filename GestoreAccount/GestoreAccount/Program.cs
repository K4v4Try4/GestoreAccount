using Model;

namespace GestoreAccount
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if(!Directory.Exists(appdata + "/GestorePassword"))
            {
                Directory.CreateDirectory(appdata + "/GestorePassword");
            }
            if(!File.Exists(appdata + "/GestorePassword/Inko.kwj"))
            {
                FileStream ff = File.Create(appdata + "/GestorePassword/Inko.kwj");
                ff.Close();
            }
            string save = appdata + "/GestorePassword/Inko.kwj";

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormLogin(save));
        }
    }
}