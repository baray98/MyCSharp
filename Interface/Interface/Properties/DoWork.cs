using System;


namespace Interface
{
	public class DoWork : IDoWork
	{
		public DoWork ()
		{

		}

		#region IDoWork implementation

		public int work (int type)
		{
			switch ((Work)type) {
			case Work.One:
				Console.WriteLine ("You wish to do 1");
				break;
			case Work.Two:
				Console.WriteLine ("You wish to do 2");
				break;
			case Work.Quit:
				Console.WriteLine ("Thanks!!!");
				return 1;
			}

			return 0;
		}

		#endregion
	}
		
}

