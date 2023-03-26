using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab_17
{
    class Triad
    {
        public int year, month, day, hour, minute, second;

        public Triad()
        {
            year = 2023;
            month = 3;
            day = 25;
            hour = 15;
            minute = 33;
            second = 14;
        }

        public int addOne(string i)
        {
            switch (i){
                case "year":
                    this.year++;
                    return this.year;
                case "month":
                    this.month++;
                    return this.month;
                case "day":
                    this.day++;
                    return this.day;
                case "hour":
                    this.hour++;
                    return this.hour;
                case "minute":
                    this.minute++;
                    return this.minute;
                case "second":
                    this.second++;
                    return this.second;
            }
            return this.year;
        }

        public void audit()
        {
            if(this.second >= 60)
            {
                this.minute += (this.second - this.second % 60) / 60;
                this.second = this.second % 60;
            }
            if (this.minute >= 60)
            {
                this.hour += (this.minute - this.minute % 60) / 60;
                this.minute = this.minute % 60;
            }
            if (this.hour >= 24)
            {
                this.day += (this.hour - this.hour % 24) / 24;
                this.hour = this.hour % 24;
            }
            if (this.day >= 30)
            {
                this.month += (this.day - this.day % 30) / 30;
                this.day = this.day % 30;
            }
            if (this.month >= 12)
            {
                this.year += (this.month - this.month % 12) / 12;
                this.month = this.month % 12;
            }
        }

        public string getYear()
        {
            string year = this.year.ToString();
            return year;
        }

        public string getMonth()
        {
            string month = this.month.ToString();
            return month;
        }

        public string getDay()
        {
            string day = this.day.ToString();
            return day;
        }

        public string getHour()
        {
            string hour = this.hour.ToString();
            return hour;
        }
        public string getMinute()
        {
            string minute = this.minute.ToString();
            return minute;
        }
        public string getSecond()
        {
            string second = this.second.ToString();
            return second;
        }

        public void Print()
        {
            //Form1.rezult_Minute1.Text = 1;
            //System.Windows.Forms.Label rezult_Minute1.Text = "123";

        }
    }

    class Date : Triad
    {
        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
    }

    class Time : Triad
    {
        public Time() : base() { }

        public Time(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

    }
}
