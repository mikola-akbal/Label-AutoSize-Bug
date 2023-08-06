namespace Label_AutoSize_Bug.Forms
{
	partial class Main_Form
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
			panel1 = new Components.Panel_File_Secret(ClientSize);
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(581, 366);
			panel1.TabIndex = 0;
			// 
			// Main_Form
			// 
			AutoScaleDimensions = new SizeF(9F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(581, 366);
			Controls.Add(panel1);
			Font = new Font("Courier New", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			Margin = new Padding(4);
			Name = "Main_Form";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Label_AutoSize_Bug";
			ResumeLayout(false);
		}

		#endregion

		private Components.Panel_File_Secret panel1;
	}
}