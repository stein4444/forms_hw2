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
        int size;
        int score;
        Point gontel;

        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            this.Text = "Kochalochka";
            this.Width = width;
            this.Height = heigh;
            GameInit();
        }


        private void GameInit()
        {
            size = 60;
            score = 0;          
            LbScore.Text = "Score: " + score;
            GenerateGantel();
            timer.Start();
        }

        private void GenerateGantel()
        {
            PiGontel.Size = new Size(size, size);
            PiGontel.Visible = true;
            gontel.X = rand.Next(0, heigh - size);
            int tempX = gontel.X % size;
            gontel.X -= tempX;
            gontel.Y = rand.Next(0, heigh - size);
            int tempY = gontel.Y % size;
            gontel.Y -= tempY;
            gontel.X++;
            gontel.Y++;
            PiGontel.Location = new Point(gontel.X, gontel.Y);
            Controls.Add(PiGontel);
        }
  
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Left:
                    PiKochka.Location = new Point(PiKochka.Location.X - size, PiKochka.Location.Y);
                    break;
                case Keys.Up:
                    PiKochka.Location = new Point(PiKochka.Location.X, PiKochka.Location.Y - size);
                    break;
                case Keys.Right:
                    PiKochka.Location = new Point(PiKochka.Location.X + size, PiKochka.Location.Y);
                    break;
                case Keys.Down:
                    PiKochka.Location = new Point(PiKochka.Location.X, PiKochka.Location.Y + size);
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

        private bool Collision(int x, int y)
        {
            return x == PiGontel.Location.X && y == PiGontel.Location.Y;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            this.LbScore.Text = "Score: " + score;
                
            if (Collision(PiKochka.Location.X  , PiKochka.Location.Y ))
            {
                score += 50;
                GenerateGantel();
            }
            if (score >= 400)
            {
                GameOver();
            }
        }
        private void GameOver()
        {           
                timer.Stop();
            this.HappyKochka.Visible = true;
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