using BUS;
using System;
using System.Threading;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        internal static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Application.Run(new Main());

        }
        /// <summary>
        /// using this to detect bug home, or you can just rebuild the solution, not build anymore
        /// </summary>
        internal static void MainDebugger()
        {
            Application.ThreadException += ThreadException;
            AppDomain.CurrentDomain.UnhandledException += UnhandledException;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var Main = new Main(); //if the debugger stopped here, problem is somewhere in the constructor chain
            Application.Run(Main); // if problem is here  then it's somewhere in the initialization chain
        }

        private static void ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.ToString());
        }

        private static void UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show(e.ExceptionObject.ToString());
        }
    }
}
