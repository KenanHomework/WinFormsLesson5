using WinFormsLesson5.MysStat;
using WinFormsLesson5.WordPadKiller;

namespace WinFormsLesson5
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            while (true)
            {
                Starter starter = new Starter();
                starter.ShowDialog();
                if (starter.ToScreen == Starter.ChangableScreens.WolfWR)
                {
                    WolfWR wolfWR = new WolfWR();
                    wolfWR.ShowDialog();

                }
                else if (starter.ToScreen == Starter.ChangableScreens.MyStat)
                {
                    MyStat mystat = new MyStat();
                    mystat.ShowDialog();
                }
                else
                    break;

            }
        }

    }
}