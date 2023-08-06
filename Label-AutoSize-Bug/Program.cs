using Label_AutoSize_Bug.Forms;




namespace Label_AutoSize_Bug
{
	public
	static
	partial
	class
	Program
	{
		[STAThread]
		static
		void
		Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.

			ApplicationConfiguration.Initialize();




			var
			Main_Form =
			new Main_Form();




			Main_Form.Show();




			Application.Run(Main_Form);
		}
	}
}
