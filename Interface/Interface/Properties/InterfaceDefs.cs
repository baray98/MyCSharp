using System;

namespace Interface
{
	enum Work
	{
		One = 1,
		Two,
		Quit,

		MaxWork
	};

	interface IDoWork
	{
		int work(int type);
	}
}

