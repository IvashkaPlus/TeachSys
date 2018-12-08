using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TeachSystem
{

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainLoginForm());
            if (Properties.Settings.Default.logined && Properties.Settings.Default.teacher_id != null)
            {
                Application.Run(new TeacherMainForm());
            }
        }
    }
}
