namespace Forms_Second_Hw
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PiKochka = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.PiGontel = new System.Windows.Forms.PictureBox();
            this.LbScore = new System.Windows.Forms.Label();
            this.HappyKochka = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PiKochka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PiGontel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HappyKochka)).BeginInit();
            this.SuspendLayout();
            // 
            // PiKochka
            // 
            this.PiKochka.BackgroundImage = global::Forms_Second_Hw.Properties.Resources.kochka;
            this.PiKochka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PiKochka.Location = new System.Drawing.Point(507, 220);
            this.PiKochka.Name = "PiKochka";
            this.PiKochka.Size = new System.Drawing.Size(90, 70);
            this.PiKochka.TabIndex = 2;
            this.PiKochka.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // PiGontel
            // 
            this.PiGontel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PiGontel.BackgroundImage = global::Forms_Second_Hw.Properties.Resources.gontel;
            this.PiGontel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PiGontel.Location = new System.Drawing.Point(649, 309);
            this.PiGontel.Name = "PiGontel";
            this.PiGontel.Size = new System.Drawing.Size(55, 61);
            this.PiGontel.TabIndex = 3;
            this.PiGontel.TabStop = false;
            // 
            // LbScore
            // 
            this.LbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbScore.Location = new System.Drawing.Point(1, 0);
            this.LbScore.Name = "LbScore";
            this.LbScore.Size = new System.Drawing.Size(162, 42);
            this.LbScore.TabIndex = 5;
            this.LbScore.Text = "Score: 0";
            // 
            // HappyKochka
            // 
            this.HappyKochka.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HappyKochka.BackgroundImage")));
            this.HappyKochka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HappyKochka.Location = new System.Drawing.Point(0, 0);
            this.HappyKochka.Name = "HappyKochka";
            this.HappyKochka.Size = new System.Drawing.Size(810, 465);
            this.HappyKochka.TabIndex = 6;
            this.HappyKochka.TabStop = false;
            this.HappyKochka.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Forms_Second_Hw.Properties.Resources.kochalka;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HappyKochka);
            this.Controls.Add(this.LbScore);
            this.Controls.Add(this.PiGontel);
            this.Controls.Add(this.PiKochka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PiKochka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PiGontel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HappyKochka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PiKochka;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox PiGontel;
        private System.Windows.Forms.Label LbScore;
        private System.Windows.Forms.PictureBox HappyKochka;
    }
}

