using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Second_Hw
{
    public partial class Form1 : Form
    {
        private int heigh = 1024;
        private int width = 768;
        private int size { get; set; }
        int score = 0;
        int stepMin = 2;
        int stepMax = 5;
        int x, y;
        Point gontel;
        public Form1()
        {
            InitializeComponent();
            size = 60;
            this.Text = "Kochalochka";
            this.Width = width;
            this.Height = heigh;
            this.LbScore.Text += score.ToString();
            
        }
        private void GenerateGantel()
        {
            this.PiGontel.Size = new Size(size,size);
            this.PiGontel.Visible = true;
            Random rand = new Random();
            gontel.X = rand.Next(0, heigh - size);
            int tempX = gontel.X % size;
            gontel.X -= tempX;
            gontel.Y = rand.Next(0, heigh - size);
            int tempY = gontel.Y % size;
            gontel.Y -= tempY;
            gontel.X++;
            gontel.Y++;
            this.PiGontel.Location = new Point(gontel.X, gontel.Y);
            this.Controls.Add(PiGontel);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (PiKochka.Location.X == gontel.X && PiKochka.Location.Y == gontel.Y)
            {
                GenerateGantel();
                this.score += 50;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Left:
                    PiKochka.Location = new Point(PiKochka.Location.X - size, PiKochka.Location.Y);
                    break;
                case Keys.Up:
                    PiKochka.Location = new Point(PiKochka.Location.X , PiKochka.Location.Y- size);
                    break;
                case Keys.Right:
                    PiKochka.Location = new Point(PiKochka.Location.X + size, PiKochka.Location.Y);
                    break;
                case Keys.Down:
                    PiKochka.Location = new Point(PiKochka.Location.X, PiKochka.Location.Y+size);      
                    break;
                case Keys.Oemplus:
                    size += 10;
                    break;
                case Keys.OemMinus:
                    size -= 10;
                    break;
                case Keys.Control:
                    break;
                default:
                    break;
            }
            this.Refresh();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
           
        }

        private void GameOver()
        {
            if(score >= 400)
            {
                DialogResult window = MessageBox.Show($"Congratulation - You Win\nYou want play again?" + MessageBoxButtons.YesNo);
                switch (window)
                {
                    case DialogResult.Yes:

                        break;
                    case DialogResult.No:
                        this.Close();
                        break;
                }
            }
        }
    }
}