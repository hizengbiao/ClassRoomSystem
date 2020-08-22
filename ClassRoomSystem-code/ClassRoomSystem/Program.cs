using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace ClassRoomSystem
{
    static class Program
    {
        
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
           //SqlConnection lo_conn = new SqlConnection("Server=服务器名字或IP;Database=数据库名字;uid=用户名;pwd=密码");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new 登录界面());
        }
    }
}
