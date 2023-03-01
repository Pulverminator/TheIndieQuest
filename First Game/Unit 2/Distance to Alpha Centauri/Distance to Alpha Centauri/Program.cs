using System;

namespace Distance_to_Alpha_Centauri
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double lightyearM = 4.365;
			double parsecM = 0.30856775812799588;
			double parsecs = lightyearM * parsecM;
			Console.WriteLine($"The distance to Alpha Centauri is: {parsecs} parsecs");
		}
	}
}
