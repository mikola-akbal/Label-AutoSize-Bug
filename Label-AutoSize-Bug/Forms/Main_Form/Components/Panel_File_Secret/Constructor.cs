namespace Label_AutoSize_Bug.Forms
{
	public
	partial
	class
	Main_Form
	{
		public
		static
		partial
		class
		Components
		{
			public
			partial
			class
			Panel_File_Secret
			{
				public
				Panel_File_Secret
				(
					Size Размер
				)
				{
					Label_Body_Length = new Label();

					TextBox_Body_Length = new TextBox();

					TextBox_Comment = new TextBox();




					SuspendLayout();




					Size = Размер;

					Dock = DockStyle.Fill;

					AutoScroll = true;

					AutoScrollMargin =
					new Size
					(
						width:		0,
						height:		5
					);

					SizeChanged += new EventHandler(Panel_SizeChanged);




					int
					TabIndex = 0;




					Label_Body_Length.Text = "Body Length:";

					Label_Body_Length.Top = 50;

					Label_Body_Length.AutoSize = true;

					Label_Body_Length.TabIndex = TabIndex++;




					// {Width=100, Height=23}
					// You see minimum 105

					TextBox_Comment.Text += $"Label_Body_Length.Size = {Label_Body_Length.Size}\r\n";




					TextBox_Body_Length.Top = Label_Body_Length.Top - 3;

					TextBox_Body_Length.Size =
					new Size
					(
						width:		120,
						height:		24
					);

					TextBox_Body_Length.ReadOnly = true;

					TextBox_Body_Length.TextAlign = HorizontalAlignment.Center;

					TextBox_Body_Length.TabIndex = TabIndex++;




					TextBox_Comment.Location =
					new Point
					(
						x:		5,
						y:		TextBox_Body_Length.Bottom + 25
					);

					TextBox_Comment.Multiline = true;

					TextBox_Comment.ReadOnly = true;

					TextBox_Comment.Height = 200;

					TextBox_Comment.ScrollBars = ScrollBars.Both;

					TextBox_Comment.TabIndex = TabIndex++;




					Set_Positions_And_Sizes_Of_Elements();




					Controls.Add(Label_Body_Length);

					Controls.Add(TextBox_Body_Length);

					Controls.Add(TextBox_Comment);




					ResumeLayout();
				}
			}
		}
	}
}
