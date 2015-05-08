using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Interface
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			IDoWork work = new DoWork ();
//			IDoWork work1 = new DoOneWork ();
//			MainMenu menu = new MainMenu(work);
//			menu.execute ();

			if (args.Length < 1)
				return;


			string s;
			try {
				StreamReader fs = new StreamReader (args [0]);
				while ((s = fs.ReadLine ()) != null) {
					Console.WriteLine (s);	
				}

				fs.Close ();
			} catch (System.IO.FileNotFoundException e) {
				Console.WriteLine ("{0} File not found!", e.FileName);
			
			}
		}
	}
}
