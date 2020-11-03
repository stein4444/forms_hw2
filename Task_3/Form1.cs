using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan time = dateTimePicker1.Value - dateTimePicker2.Value;
            int days = time.Days;
            if(days < 0)
            {
                days *= (-1);
                this.label1.Text = "Days: "+days.ToString();
            } 
            else
            this.label1.Text = "Days: " + days.ToString();
;        }
       
    }
}
