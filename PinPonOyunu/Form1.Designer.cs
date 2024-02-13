namespace PinPonOyunu
{
    partial class pinponform
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
            this.oyunalani = new System.Windows.Forms.Panel();
            this.gameover_lbl = new System.Windows.Forms.Label();
            this.score_lbl = new System.Windows.Forms.Label();
            this.point_lbl = new System.Windows.Forms.Label();
            this.racet = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.oyunalani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // oyunalani
            // 
            this.oyunalani.Controls.Add(this.gameover_lbl);
            this.oyunalani.Controls.Add(this.score_lbl);
            this.oyunalani.Controls.Add(this.point_lbl);
            this.oyunalani.Controls.Add(this.racet);
            this.oyunalani.Controls.Add(this.ball);
            this.oyunalani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oyunalani.Location = new System.Drawing.Point(0, 0);
            this.oyunalani.Name = "oyunalani";
            this.oyunalani.Size = new System.Drawing.Size(800, 450);
            this.oyunalani.TabIndex = 0;
            // 
            // gameover_lbl
            // 
            this.gameover_lbl.AutoSize = true;
            this.gameover_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gameover_lbl.Location = new System.Drawing.Point(324, 96);
            this.gameover_lbl.Name = "gameover_lbl";
            this.gameover_lbl.Size = new System.Drawing.Size(428, 174);
            this.gameover_lbl.TabIndex = 5;
            this.gameover_lbl.Text = "     Game Over!\r\nF1-Restart Game\r\nEsc-Exit";
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.score_lbl.Location = new System.Drawing.Point(12, 35);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(176, 58);
            this.score_lbl.TabIndex = 4;
            this.score_lbl.Text = "Score:";
            // 
            // point_lbl
            // 
            this.point_lbl.AutoSize = true;
            this.point_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.point_lbl.Location = new System.Drawing.Point(194, 35);
            this.point_lbl.Name = "point_lbl";
            this.point_lbl.Size = new System.Drawing.Size(54, 58);
            this.point_lbl.TabIndex = 3;
            this.point_lbl.Text = "0";
            this.point_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // racet
            // 
            this.racet.BackColor = System.Drawing.Color.Black;
            this.racet.Location = new System.Drawing.Point(229, 313);
            this.racet.Name = "racet";
            this.racet.Size = new System.Drawing.Size(270, 27);
            this.racet.TabIndex = 1;
            this.racet.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Green;
            this.ball.Location = new System.Drawing.Point(12, 96);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(33, 39);
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pinponform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.oyunalani);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pinponform";
            this.Text = "Pin Pon Game";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pinponform_KeyDown);
            this.oyunalani.ResumeLayout(false);
            this.oyunalani.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel oyunalani;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox racet;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.Label point_lbl;
        private System.Windows.Forms.Label gameover_lbl;
        private System.Windows.Forms.Timer timer1;
    }
}

