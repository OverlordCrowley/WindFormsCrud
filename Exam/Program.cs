using System;
using System.Windows.Forms;

namespace Exam
{
    public static class Program
    {
        private static readonly postgresContext Context = new postgresContext();
        private static ChessPlayerRepository ChessPlayerRepository = new ChessPlayerRepository(Context);
        [STAThread]
        public static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(Context, ChessPlayerRepository));
        }
    }
}
