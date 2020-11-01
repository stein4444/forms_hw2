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
            this.LbTextScore = new System.Windows.Forms.Label();
            this.LbScore = new System.Windows.Forms.Label();
            this.PiKochka = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.PiGontel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PiKochka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PiGontel)).BeginInit();
            this.SuspendLayout();
            // 
            // LbTextScore
            // 
            this.LbTextScore.BackColor = System.Drawing.SystemColors.Control;
            this.LbTextScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbTextScore.Location = new System.Drawing.Point(12, 9);
            this.LbTextScore.Name = "LbTextScore";
            this.LbTextScore.Size = new System.Drawing.Size(111, 40);
            this.LbTextScore.TabIndex = 0;
            this.LbTextScore.Text = "Score";
            // 
            // LbScore
            // 
            this.LbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbScore.Location = new System.Drawing.Point(142, 9);
            this.LbScore.Name = "LbScore";
            this.LbScore.Size = new System.Drawing.Size(84, 40);
            this.LbScore.TabIndex = 1;
            // 
            // PiKochka
            // 
            this.PiKochka.BackgroundImage = global::Forms_Second_Hw.Properties.Resources.kochka;
            this.PiKochka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PiKochka.Location = new System.Drawing.Point(136, 237);
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
            this.PiGontel.Location = new System.Drawing.Point(664, 246);
            this.PiGontel.Name = "PiGontel";
            this.PiGontel.Size = new System.Drawing.Size(55, 61);
            this.PiGontel.TabIndex = 3;
            this.PiGontel.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Forms_Second_Hw.Properties.Resources.kochalka;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PiGontel);
            this.Controls.Add(this.PiKochka);
            this.Controls.Add(this.LbScore);
            this.Controls.Add(this.LbTextScore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PiKochka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PiGontel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LbTextScore;
        private System.Windows.Forms.Label LbScore;
        private System.Windows.Forms.PictureBox PiKochka;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox PiGontel;
    }
}

