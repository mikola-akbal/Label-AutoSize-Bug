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
				private
				void
				Set_Positions_And_Sizes_Of_Elements()
				{
					const
					int
					Distance_Between_Label_And_TextBox_Body_Length = 6;




					int
					Label_Body_Length_Left =
					(Width - Label_Body_Length.Width - TextBox_Body_Length.Width - Distance_Between_Label_And_TextBox_Body_Length) / 2;

					TextBox_Comment.Text += $"Width = {Width}\r\n";




					// 100
					// You see minimum 105
					TextBox_Comment.Text += $"Label_Body_Length.Width = {Label_Body_Length.Width}\r\n";




					TextBox_Comment.Text += $"TextBox_Body_Length.Width = {TextBox_Body_Length.Width}\r\n";
					TextBox_Comment.Text += $"Distance_Between_Label_And_TextBox_Body_Length = {Distance_Between_Label_And_TextBox_Body_Length}\r\n";
					TextBox_Comment.Text += $"Label_Body_Length_Left = {Label_Body_Length_Left}\r\n";

					if (Label_Body_Length.Left != Label_Body_Length_Left)
					{
						Label_Body_Length.Left = Label_Body_Length_Left;
					}




					int
					TextBox_Body_Length_Left =
					Label_Body_Length.Right + Distance_Between_Label_And_TextBox_Body_Length;

					TextBox_Comment.Text += $"Label_Body_Length.Right = {Label_Body_Length.Right}\r\n";
					TextBox_Comment.Text += $"Distance_Between_Label_And_TextBox_Body_Length = {Distance_Between_Label_And_TextBox_Body_Length}\r\n";
					TextBox_Comment.Text += $"TextBox_Body_Length_Left = {TextBox_Body_Length_Left}\r\n";

					if (TextBox_Body_Length.Left != TextBox_Body_Length_Left)
					{
						TextBox_Body_Length.Left = TextBox_Body_Length_Left;
					}




					int
					TextBox_Comment_Left =
					Width - TextBox_Comment.Left - 5;

					if (TextBox_Comment.Width != TextBox_Comment_Left)
					{
						TextBox_Comment.Width = TextBox_Comment_Left;
					}
				}
			}
		}
	}
}
