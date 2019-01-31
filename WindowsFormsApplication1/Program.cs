namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
           System.Windows.Forms.Application.EnableVisualStyles();
           System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
           System.Windows.Forms.Application.Run(new LoginForm());
        }
    }
}
