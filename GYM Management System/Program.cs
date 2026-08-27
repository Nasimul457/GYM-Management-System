namespace GYM_Management_System
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
             Application.Run(new LoginForm());

            // Application.Run(new MainForm());
            //Application.Run(new AddMember());
            // Application.Run(new ViewMembers());

            // Application.Run(new UpdateDelete());

            //Application.Run(new Payment());
           // Application.Run(new ViewMembers());

        }
    }
}