using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Binary_Clock
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        int _Sec_1;
        int _Sec_2;
        int _Min_1;
        int _Min_2;
        int _Hour_1;
        int _Hour_2;
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Calc_to_bin_sec_1(int x)
        {
            x = _Sec_1;
            switch (x)
            {
                case 0:
                    LED_Sec_1_1.BackColor = Color.White;
                    LED_Sec_1_2.BackColor = Color.White;
                    LED_Sec_1_3.BackColor = Color.White;
                    LED_Sec_1_4.BackColor = Color.White;
                    break;
                case 1:
                    LED_Sec_1_1.BackColor = Color.Blue;
                    LED_Sec_1_2.BackColor = Color.White;
                    LED_Sec_1_3.BackColor = Color.White;
                    LED_Sec_1_4.BackColor = Color.White;
                    break;
                case 2:
                    LED_Sec_1_1.BackColor = Color.White;
                    LED_Sec_1_2.BackColor = Color.Blue;
                    LED_Sec_1_3.BackColor = Color.White;
                    LED_Sec_1_4.BackColor = Color.White;
                    break;
                case 3:
                    LED_Sec_1_1.BackColor = Color.Blue;
                    LED_Sec_1_2.BackColor = Color.Blue;
                    LED_Sec_1_3.BackColor = Color.White;
                    LED_Sec_1_4.BackColor = Color.White;
                    break;
                case 4:
                    LED_Sec_1_1.BackColor = Color.White;
                    LED_Sec_1_2.BackColor = Color.White;
                    LED_Sec_1_3.BackColor = Color.Blue;
                    LED_Sec_1_4.BackColor = Color.White;
                    break;
                case 5:
                    LED_Sec_1_1.BackColor = Color.Blue;
                    LED_Sec_1_2.BackColor = Color.White;
                    LED_Sec_1_3.BackColor = Color.Blue;
                    LED_Sec_1_4.BackColor = Color.White;
                    break;
                case 6:
                    LED_Sec_1_1.BackColor = Color.White;
                    LED_Sec_1_2.BackColor = Color.Blue;
                    LED_Sec_1_3.BackColor = Color.Blue;
                    LED_Sec_1_4.BackColor = Color.White;
                    break;
                case 7:
                    LED_Sec_1_1.BackColor = Color.Blue;
                    LED_Sec_1_2.BackColor = Color.Blue;
                    LED_Sec_1_3.BackColor = Color.Blue;
                    LED_Sec_1_4.BackColor = Color.White;
                    break;
                case 8:
                    LED_Sec_1_1.BackColor = Color.White;
                    LED_Sec_1_2.BackColor = Color.White;
                    LED_Sec_1_3.BackColor = Color.White;
                    LED_Sec_1_4.BackColor = Color.Blue;
                    break;
                case 9:
                    LED_Sec_1_1.BackColor = Color.Blue;
                    LED_Sec_1_2.BackColor = Color.White;
                    LED_Sec_1_3.BackColor = Color.White;
                    LED_Sec_1_4.BackColor = Color.Blue;
                    break;
            }
        }
        public void Calc_to_bin_sec_2(int x)
        {
            x = _Sec_2;
            switch (x)
            {
                case 0:
                    LED_Sec_2_1.BackColor = Color.White;
                    LED_Sec_2_2.BackColor = Color.White;
                    LED_Sec_2_3.BackColor = Color.White;
                    break;
                case 1:
                    LED_Sec_2_1.BackColor = Color.Blue;
                    LED_Sec_2_2.BackColor = Color.White;
                    LED_Sec_2_3.BackColor = Color.White;
                    break;
                case 2:
                    LED_Sec_2_1.BackColor = Color.White;
                    LED_Sec_2_2.BackColor = Color.Blue;
                    LED_Sec_2_3.BackColor = Color.White;
                    break;
                case 3:
                    LED_Sec_2_1.BackColor = Color.Blue;
                    LED_Sec_2_2.BackColor = Color.Blue;
                    LED_Sec_2_3.BackColor = Color.White;
                    break;
                case 4:
                    LED_Sec_2_1.BackColor = Color.White;
                    LED_Sec_2_2.BackColor = Color.White;
                    LED_Sec_2_3.BackColor = Color.Blue;
                    break;
                case 5:
                    LED_Sec_2_1.BackColor = Color.Blue;
                    LED_Sec_2_2.BackColor = Color.White;
                    LED_Sec_2_3.BackColor = Color.Blue;
                    break;
            }
        }
        public void Calc_to_bin_min_1(int x)
        {
            x = _Min_1;
            switch (x)
            {
                case 0:
                    LED_Min_1_1.BackColor = Color.White;
                    LED_Min_1_2.BackColor = Color.White;
                    LED_Min_1_3.BackColor = Color.White;
                    LED_Min_1_4.BackColor = Color.White;
                    break;
                case 1:
                    LED_Min_1_1.BackColor = Color.Blue;
                    LED_Min_1_2.BackColor = Color.White;
                    LED_Min_1_3.BackColor = Color.White;
                    LED_Min_1_4.BackColor = Color.White;
                    break;
                case 2:
                    LED_Min_1_1.BackColor = Color.White;
                    LED_Min_1_2.BackColor = Color.Blue;
                    LED_Min_1_3.BackColor = Color.White;
                    LED_Min_1_4.BackColor = Color.White;
                    break;
                case 3:
                    LED_Min_1_1.BackColor = Color.Blue;
                    LED_Min_1_2.BackColor = Color.Blue;
                    LED_Min_1_3.BackColor = Color.White;
                    LED_Min_1_4.BackColor = Color.White;
                    break;
                case 4:
                    LED_Min_1_1.BackColor = Color.White;
                    LED_Min_1_2.BackColor = Color.White;
                    LED_Min_1_3.BackColor = Color.Blue;
                    LED_Min_1_4.BackColor = Color.White;
                    break;
                case 5:
                    LED_Min_1_1.BackColor = Color.Blue;
                    LED_Min_1_2.BackColor = Color.White;
                    LED_Min_1_3.BackColor = Color.Blue;
                    LED_Min_1_4.BackColor = Color.White;
                    break;
                case 6:
                    LED_Min_1_1.BackColor = Color.White;
                    LED_Min_1_2.BackColor = Color.Blue;
                    LED_Min_1_3.BackColor = Color.Blue;
                    LED_Min_1_4.BackColor = Color.White;
                    break;
                case 7:
                    LED_Min_1_1.BackColor = Color.Blue;
                    LED_Min_1_2.BackColor = Color.Blue;
                    LED_Min_1_3.BackColor = Color.Blue;
                    LED_Min_1_4.BackColor = Color.White;
                    break;
                case 8:
                    LED_Min_1_1.BackColor = Color.White;
                    LED_Min_1_2.BackColor = Color.White;
                    LED_Min_1_3.BackColor = Color.White;
                    LED_Min_1_4.BackColor = Color.Blue;
                    break;
                case 9:
                    LED_Min_1_1.BackColor = Color.Blue;
                    LED_Min_1_2.BackColor = Color.White;
                    LED_Min_1_3.BackColor = Color.White;
                    LED_Min_1_4.BackColor = Color.Blue;
                    break;
            }
        }
        public void Calc_to_bin_min_2(int x)
        {
            x = _Min_2;
            switch (x)
            {
                case 0:
                    LED_Min_2_1.BackColor = Color.White;
                    LED_Min_2_2.BackColor = Color.White;
                    LED_Min_2_3.BackColor = Color.White;
                    break;
                case 1:
                    LED_Min_2_1.BackColor = Color.Blue;
                    LED_Min_2_2.BackColor = Color.White;
                    LED_Min_2_3.BackColor = Color.White;
                    break;
                case 2:
                    LED_Min_2_1.BackColor = Color.White;
                    LED_Min_2_2.BackColor = Color.Blue;
                    LED_Min_2_3.BackColor = Color.White;
                    break;
                case 3:
                    LED_Min_2_1.BackColor = Color.Blue;
                    LED_Min_2_2.BackColor = Color.Blue;
                    LED_Min_2_3.BackColor = Color.White;
                    break;
                case 4:
                    LED_Min_2_1.BackColor = Color.White;
                    LED_Min_2_2.BackColor = Color.White;
                    LED_Min_2_3.BackColor = Color.Blue;
                    break;
                case 5:
                    LED_Min_2_1.BackColor = Color.Blue;
                    LED_Min_2_2.BackColor = Color.White;
                    LED_Min_2_3.BackColor = Color.Blue;
                    break;
            }
        }
        public void Calc_to_bin_hour_1(int x)
        {
            x = _Hour_1;
            switch (x)
            {
                case 0:
                    LED_Hour_1_1.BackColor = Color.White;
                    LED_Hour_1_2.BackColor = Color.White;
                    LED_Hour_1_3.BackColor = Color.White;
                    LED_Hour_1_4.BackColor = Color.White;
                    break;
                case 1:
                    LED_Hour_1_1.BackColor = Color.Blue;
                    LED_Hour_1_2.BackColor = Color.White;
                    LED_Hour_1_3.BackColor = Color.White;
                    LED_Hour_1_4.BackColor = Color.White;
                    break;
                case 2:
                    LED_Hour_1_1.BackColor = Color.White;
                    LED_Hour_1_2.BackColor = Color.Blue;
                    LED_Hour_1_3.BackColor = Color.White;
                    LED_Hour_1_4.BackColor = Color.White;
                    break;
                case 3:
                    LED_Hour_1_1.BackColor = Color.Blue;
                    LED_Hour_1_2.BackColor = Color.Blue;
                    LED_Hour_1_3.BackColor = Color.White;
                    LED_Hour_1_4.BackColor = Color.White;
                    break;
                case 4:
                    LED_Hour_1_1.BackColor = Color.White;
                    LED_Hour_1_2.BackColor = Color.White;
                    LED_Hour_1_3.BackColor = Color.Blue;
                    LED_Hour_1_4.BackColor = Color.White;
                    break;
                case 5:
                    LED_Hour_1_1.BackColor = Color.Blue;
                    LED_Hour_1_2.BackColor = Color.White;
                    LED_Hour_1_3.BackColor = Color.Blue;
                    LED_Hour_1_4.BackColor = Color.White;
                    break;
                case 6:
                    LED_Hour_1_1.BackColor = Color.White;
                    LED_Hour_1_2.BackColor = Color.Blue;
                    LED_Hour_1_3.BackColor = Color.Blue;
                    LED_Hour_1_4.BackColor = Color.White;
                    break;
                case 7:
                    LED_Hour_1_1.BackColor = Color.Blue;
                    LED_Hour_1_2.BackColor = Color.Blue;
                    LED_Hour_1_3.BackColor = Color.Blue;
                    LED_Hour_1_4.BackColor = Color.White;
                    break;
                case 8:
                    LED_Hour_1_1.BackColor = Color.White;
                    LED_Hour_1_2.BackColor = Color.White;
                    LED_Hour_1_3.BackColor = Color.White;
                    LED_Hour_1_4.BackColor = Color.Blue;
                    break;
                case 9:
                    LED_Hour_1_1.BackColor = Color.Blue;
                    LED_Hour_1_2.BackColor = Color.White;
                    LED_Hour_1_3.BackColor = Color.White;
                    LED_Hour_1_4.BackColor = Color.Blue;
                    break;
            }
        }
        public void Calc_to_bin_hour_2(int x)
        {
            x = _Hour_2;
            switch (x)
            {
                case 0:
                    LED_Hour_2_1.BackColor = Color.White;
                    LED_Hour_2_2.BackColor = Color.White;
                    break;
                case 1:
                    LED_Hour_2_1.BackColor = Color.Blue;
                    LED_Hour_2_2.BackColor = Color.White;
                    break;
                case 2:
                    LED_Hour_2_1.BackColor = Color.White;
                    LED_Hour_2_2.BackColor = Color.Blue;
                    break;
            }
        }
        private void Welcome_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            string sec = DateTime.Now.Second.ToString();
            if (sec.Length == 1)
            {
                sec = "0" + sec;
            }
            _Sec_1 = int.Parse(sec[1].ToString());
            _Sec_2 = int.Parse(sec[0].ToString());
            string min = DateTime.Now.Minute.ToString();
            if (min.Length == 1)
            {
                min = "0" + min;
            }
            _Min_1 = int.Parse(min[1].ToString());
            _Min_2 = int.Parse(min[0].ToString());
            string hour = DateTime.Now.Hour.ToString();
            if (hour.Length == 1)
            {
                hour = "0" + hour;
            }
            _Hour_1 = int.Parse(hour[1].ToString());
            _Hour_2 = int.Parse(hour[0].ToString());
            Calc_to_bin_sec_1(_Sec_1);
            Calc_to_bin_sec_2(_Sec_2);
            Calc_to_bin_min_1(_Min_1);
            Calc_to_bin_min_2(_Min_2);
            Calc_to_bin_hour_1(_Hour_1);
            Calc_to_bin_hour_2(_Hour_2);
        }
    }
}