using System;

namespace Interface
{
	class MainMenu
	{
		private readonly IDoWork m_Work;
		public MainMenu(IDoWork doWork)
		{
			m_Work = doWork;
		}

		public void execute()
		{
			int result = 0;
			while (result == 0) {
				Console.WriteLine ("Please choose option");
				Console.WriteLine ("\t[1] Do it");
				Console.WriteLine ("\t[2] Try it");
				Console.WriteLine ("\t[3] quit");

				String input = Console.ReadLine();
				try{
					result = m_Work.work (Convert.ToInt32 (input));
				}
				catch {
					Console.WriteLine ("{0} Is not a valid input", input);
					result = 0;
				}
			}

		}
	}
}
