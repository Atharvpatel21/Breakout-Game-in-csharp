namespace BreakOut_Game
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
            this.txtscore = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // txtscore
            // 
            this.txtscore.AutoSize = true;
            this.txtscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore.ForeColor = System.Drawing.Color.White;
            this.txtscore.Location = new System.Drawing.Point(12, 10);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(80, 20);
            this.txtscore.TabIndex = 0;
            this.txtscore.Text = "Score :0";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.White;
            this.player.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player.Location = new System.Drawing.Point(347, 492);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 32);
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Yellow;
            this.ball.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ball.Location = new System.Drawing.Point(379, 342);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(25, 27);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1032, 528);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.player);
            this.Controls.Add(this.txtscore);
            this.Name = "Form1";
            this.Text = "Breakout Game MDO ICT";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtscore;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer GameTimer;
    }
}

