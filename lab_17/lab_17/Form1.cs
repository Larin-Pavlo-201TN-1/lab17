using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace lab_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Year_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            e.Handled = true;
        }

        private void Month_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            e.Handled = true;
        }

        private void Day_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            e.Handled = true;
        }

        private void Hour_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            e.Handled = true;
        }

        private void Minute_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            e.Handled = true;
        }

        private void Second_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            e.Handled = true;
        }

        private void btn_Year_Click(object sender, EventArgs e)
        {
            Time time = new Time(Convert.ToInt32(rezult_Hour.Text), Convert.ToInt32(rezult_Minute.Text), Convert.ToInt32(rezult_Second.Text));
            Date date = new Date(Convert.ToInt32(rezult_Year.Text), Convert.ToInt32(rezult_Month.Text), Convert.ToInt32(rezult_Day.Text));
            date.addOne("year");
            date.audit();
            time.audit();
            rezult_Second.Text = time.getSecond();
            rezult_Minute.Text = time.getMinute();
            rezult_Hour.Text = time.getHour();
            rezult_Day.Text = date.getDay();
            rezult_Month.Text = date.getMonth();
            rezult_Year.Text = date.getYear();
        }

        private void btn_Month_Click(object sender, EventArgs e)
        {
            Time time = new Time(Convert.ToInt32(rezult_Hour.Text), Convert.ToInt32(rezult_Minute.Text), Convert.ToInt32(rezult_Second.Text));
            Date date = new Date(Convert.ToInt32(rezult_Year.Text), Convert.ToInt32(rezult_Month.Text), Convert.ToInt32(rezult_Day.Text));
            date.addOne("month");
            date.audit();
            time.audit();
            rezult_Second.Text = time.getSecond();
            rezult_Minute.Text = time.getMinute();
            rezult_Hour.Text = time.getHour();
            rezult_Day.Text = date.getDay();
            rezult_Month.Text = date.getMonth();
            rezult_Year.Text = date.getYear();
        }

        private void btn_Day_Click(object sender, EventArgs e)
        {
            Time time = new Time(Convert.ToInt32(rezult_Hour.Text), Convert.ToInt32(rezult_Minute.Text), Convert.ToInt32(rezult_Second.Text));
            Date date = new Date(Convert.ToInt32(rezult_Year.Text), Convert.ToInt32(rezult_Month.Text), Convert.ToInt32(rezult_Day.Text));
            date.addOne("day");
            date.audit();
            time.audit();
            rezult_Second.Text = time.getSecond();
            rezult_Minute.Text = time.getMinute();
            rezult_Hour.Text = time.getHour();
            rezult_Day.Text = date.getDay();
            rezult_Month.Text = date.getMonth();
            rezult_Year.Text = date.getYear();
        }

        private void btn_Hour_Click(object sender, EventArgs e)
        {
            Date date = new Date(Convert.ToInt32(rezult_Year.Text), Convert.ToInt32(rezult_Month.Text), Convert.ToInt32(rezult_Day.Text));
            Time time = new Time(Convert.ToInt32(rezult_Hour.Text), Convert.ToInt32(rezult_Minute.Text), Convert.ToInt32(rezult_Second.Text));
            time.addOne("hour");
            time.audit();
            date.audit();
            rezult_Second.Text = time.getSecond();
            rezult_Minute.Text = time.getMinute();
            rezult_Hour.Text = time.getHour();
            rezult_Day.Text = date.getDay();
            rezult_Month.Text = date.getMonth();
            rezult_Year.Text = date.getYear();
        }

        private void btn_Minute_Click(object sender, EventArgs e)
        {
            Date date = new Date(Convert.ToInt32(rezult_Year.Text), Convert.ToInt32(rezult_Month.Text), Convert.ToInt32(rezult_Day.Text));
            Time time = new Time(Convert.ToInt32(rezult_Hour.Text), Convert.ToInt32(rezult_Minute.Text), Convert.ToInt32(rezult_Second.Text));
            time.addOne("minute");
            time.audit();
            date.audit();
            rezult_Second.Text = time.getSecond();
            rezult_Minute.Text = time.getMinute();
            rezult_Hour.Text = time.getHour();
            rezult_Day.Text = date.getDay();
            rezult_Month.Text = date.getMonth();
            rezult_Year.Text = date.getYear();
        }

        private void btn_Second_Click(object sender, EventArgs e)
        {
            Date date = new Date(Convert.ToInt32(rezult_Year.Text), Convert.ToInt32(rezult_Month.Text), Convert.ToInt32(rezult_Day.Text));
            Time time = new Time(Convert.ToInt32(rezult_Hour.Text), Convert.ToInt32(rezult_Minute.Text), Convert.ToInt32(rezult_Second.Text));
            time.addOne("second");
            time.audit();
            date.audit();
            rezult_Second.Text = time.getSecond();
            rezult_Minute.Text = time.getMinute();
            rezult_Hour.Text = time.getHour();
            rezult_Day.Text = date.getDay();
            rezult_Month.Text = date.getMonth();
            rezult_Year.Text = date.getYear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Triad triad = new Triad();
            if(Year_txt.Text != "")
            {
                rezult_Year.Text = Year_txt.Text;
            }
            else
            {
                rezult_Year.Text = triad.getYear();
            }
            if (Month_txt.Text != "")
            {
                rezult_Month.Text = Month_txt.Text;
            }
            else
            {
                rezult_Month.Text = triad.getMonth();
            }
            if (Day_txt.Text != "")
            {
                rezult_Day.Text = Day_txt.Text;
            }
            else
            {
                rezult_Day.Text = triad.getDay();
            }
            if (Hour_txt.Text != "")
            {
                rezult_Hour.Text = Hour_txt.Text;
            }
            else
            {
                rezult_Hour.Text = triad.getHour();
            }
            if (Minute_txt.Text != "")
            {
                rezult_Minute.Text = Minute_txt.Text;
            }
            else
            {
                rezult_Minute.Text = triad.getMinute();
            }
            if (Second_txt.Text != "")
            {
                rezult_Second.Text = Second_txt.Text;
            }
            else
            {
                rezult_Second.Text = triad.getSecond();
            }
        }
    }
}
