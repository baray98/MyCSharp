using System;
using Bryan;

namespace Cons
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			Bryan.BryanName b = new BryanName();
			String n = b.name ();
			Console.WriteLine (n);
		}
	}
}
