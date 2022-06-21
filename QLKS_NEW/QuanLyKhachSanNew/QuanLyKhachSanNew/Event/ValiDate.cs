using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSanNew.Event
{
    public class ValiDate
    {
        /// <summary>
        /// Hàm thông báo với thời gian trể
        /// </summary>
        /// <param name="lbl"></param>
        /// <param name="time"></param>
        /// <param name="message"></param>
        public static void MessageTime(System.Windows.Forms.Label lbl, int time, String message)
        {
            String strLuu = lbl.Text;
            lbl.Text = message;
            for (int i = 0; i < time; i++)
            {
                Thread.Sleep(time);
            }
            lbl.Text = strLuu;
        }

        /// <summary>
        /// Hàm tạo thời gian chờ nhận sự kiện
        /// </summary>
        static public void mySleep(int ms)
        {
            for (int i = 0; i < ms; i++) 
            {
                Thread.Sleep(ms);            
            }
        }

    }
}
