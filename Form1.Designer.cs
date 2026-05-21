namespace pingg
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
			this.ball = new System.Windows.Forms.PictureBox();
			this.computer = new System.Windows.Forms.PictureBox();
			this.player = new System.Windows.Forms.PictureBox();
			this.GameTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.computer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
			this.SuspendLayout();
			// 
			// ball
			// 
			this.ball.Image = global::pingg.Properties.Resources.ball;
			this.ball.Location = new System.Drawing.Point(376, 180);
			this.ball.Name = "ball";
			this.ball.Size = new System.Drawing.Size(30, 30);
			this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ball.TabIndex = 2;
			this.ball.TabStop = false;
			// 
			// computer
			// 
			this.computer.Image = global::pingg.Properties.Resources.computer;
			this.computer.Location = new System.Drawing.Point(769, 147);
			this.computer.Name = "computer";
			this.computer.Size = new System.Drawing.Size(30, 120);
			this.computer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.computer.TabIndex = 1;
			this.computer.TabStop = false;
			// 
			// player
			// 
			this.player.Image = global::pingg.Properties.Resources.player;
			this.player.Location = new System.Drawing.Point(2, 147);
			this.player.Name = "player";
			this.player.Size = new System.Drawing.Size(30, 120);
			this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.player.TabIndex = 0;
			this.player.TabStop = false;
			// 
			// GameTimer
			// 
			this.GameTimer.Enabled = true;
			this.GameTimer.Interval = 20;
			this.GameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ball);
			this.Controls.Add(this.computer);
			this.Controls.Add(this.player);
			this.DoubleBuffered = true;
			this.Name = "Form1";
			this.Text = "player 0 .... computer  0";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
			((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.computer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox player;
		private System.Windows.Forms.PictureBox computer;
		private System.Windows.Forms.PictureBox ball;
		private System.Windows.Forms.Timer GameTimer;
	}
}

