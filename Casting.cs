using System;

public class Casting
{
	public static void casting()
	{
		//converting String to bool 
		String isMale = "true";
		bool isMaleBool=bool.Parse(isMale);
		//
		int intergerFromString = int.Parse("589203");
		double dFromString = double.Parse("1.25");

		double dblNum = 13.245;
		//Excicite Data-loosing somedata
		int Numb = (int)dblNum;

		//formating the uutpit
		Console.WriteLine("Currency :  {0:c", 23.974);
		Console.WriteLine("Pad with 0s: {0:d4}", 23);
		Console.WriteLine("Pad with 0s: {0:f3}", 23.45457856433); //To Three decimal place
		Console.WriteLine("Pad with 0s: {0:n4}", 2345457856433); //Add commas


    }
}
