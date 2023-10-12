using System;

public class Variables
{
	public static void variables()
	{
		bool isMale = true;
		Console.WriteLine("Biggest integer is {0}", int.MaxValue);
		Console.WriteLine("Smallest integer is {0}", int.MinValue);

		Console.WriteLine("Biggest Long {0}", long.MinValue);
		Console.WriteLine("Smallest Long {0}", long.MinValue);


		decimal votes = 3.0000M;
		decimal decBigNum = 3.000000000000000000000000000000000M;
		Console.WriteLine("Votes+ decBigNum {0}",votes + decBigNum);
    }
}
