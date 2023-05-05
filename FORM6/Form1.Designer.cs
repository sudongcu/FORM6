namespace FORM6
{
	partial class Six
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Six));
			this.img_btn_start = new System.Windows.Forms.PictureBox();
			this.lbl_title = new System.Windows.Forms.Label();
			this.img_btn_close = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.img_btn_start)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.img_btn_close)).BeginInit();
			this.SuspendLayout();
			// 
			// img_btn_start
			// 
			this.img_btn_start.Image = global::FORM6.Properties.Resources.img_start;
			this.img_btn_start.Location = new System.Drawing.Point(148, 675);
			this.img_btn_start.Name = "img_btn_start";
			this.img_btn_start.Size = new System.Drawing.Size(500, 100);
			this.img_btn_start.TabIndex = 0;
			this.img_btn_start.TabStop = false;
			this.img_btn_start.Click += new System.EventHandler(this.img_btn_start_Click);
			// 
			// lbl_title
			// 
			this.lbl_title.AutoSize = true;
			this.lbl_title.Font = new System.Drawing.Font("Impact", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_title.Location = new System.Drawing.Point(141, 124);
			this.lbl_title.Name = "lbl_title";
			this.lbl_title.Size = new System.Drawing.Size(515, 324);
			this.lbl_title.TabIndex = 1;
			this.lbl_title.Text = "FORM\r\nBY NET 6";
			// 
			// img_btn_close
			// 
			this.img_btn_close.Image = ((System.Drawing.Image)(resources.GetObject("img_btn_close.Image")));
			this.img_btn_close.Location = new System.Drawing.Point(148, 814);
			this.img_btn_close.Name = "img_btn_close";
			this.img_btn_close.Size = new System.Drawing.Size(500, 100);
			this.img_btn_close.TabIndex = 2;
			this.img_btn_close.TabStop = false;
			this.img_btn_close.Click += new System.EventHandler(this.img_btn_close_Click);
			// 
			// Six
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Navy;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(804, 1084);
			this.ControlBox = false;
			this.Controls.Add(this.img_btn_close);
			this.Controls.Add(this.lbl_title);
			this.Controls.Add(this.img_btn_start);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Six";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Six";
			((System.ComponentModel.ISupportInitialize)(this.img_btn_start)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.img_btn_close)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private PictureBox img_btn_start;
		private Label lbl_title;
		private PictureBox img_btn_close;
	}
}