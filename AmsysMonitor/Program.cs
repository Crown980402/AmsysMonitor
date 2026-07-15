using System;
using System.Threading;
using System.Windows.Forms;
using AmsysMonitor.Utils;

namespace AmsysMonitor
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // UI 스레드 예외
            Application.ThreadException += Application_ThreadException;

            // UI 외 스레드 예외
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            Application.SetUnhandledExceptionMode(
                UnhandledExceptionMode.CatchException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                Logger.Error("Application.Run 예외");
                Logger.Error(ex.ToString());

                MessageBox.Show(
                    "예상하지 못한 오류가 발생했습니다.\nMonitorLog.txt를 확인해주세요.",
                    "Amsys Monitor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private static void Application_ThreadException(
            object sender,
            ThreadExceptionEventArgs e)
        {
            Logger.Error("UI Thread 예외");
            Logger.Error(e.Exception.ToString());

            MessageBox.Show(
                "프로그램 오류가 발생했습니다.\nMonitorLog.txt를 확인해주세요.",
                "Amsys Monitor",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private static void CurrentDomain_UnhandledException(
            object sender,
            UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject is Exception ex)
            {
                Logger.Error("UnhandledException");
                Logger.Error(ex.ToString());
            }
        }
    }
}