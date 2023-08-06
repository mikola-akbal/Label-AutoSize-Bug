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
				Panel_SizeChanged(object sender, EventArgs e)
				{
					SuspendLayout();




					Set_Positions_And_Sizes_Of_Elements();




					ResumeLayout();
				}
			}
		}
	}
}
