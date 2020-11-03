using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Day_TextChanged(object sender, EventArgs e)
        {
            int days;
            if (int.Parse(this.Day.Text)> 31 && int.Parse(this.Day.Text) <= 0)
            {
                MessageBox.Show("Bad value");
            }
            else
            {
                days = int.Parse(this.Day.Text);
           // monthCalendar1.AddBoldedDate(new DateTime(0, 0, days));
            }

        }

        private void month_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(this.month.Text) > 12 && int.Parse(this.month.Text) <= 0)
            {
                MessageBox.Show("Bad value");
            }
        }

        private void Year_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(this.Year.Text) > 2020 && int.Parse(this.Year.Text) <= 1900)
            {
                MessageBox.Show("Bad value");
            }

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            int days, month, years;
            years = int.Parse(this.Year.Text);
            month = int.Parse(this.month.Text);
            days = int.Parse(this.Day.Text);
            DateTime date = new DateTime(years, month, days);
            monthCalendar1.AddMonthlyBoldedDate(date);
           
        }
    }
}
