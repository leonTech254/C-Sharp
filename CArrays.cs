using System;

public class CArrays
{
	public static void cArray()
	{
		int[] a = new int[] { 1, 2, 3, 4, };
		Console.WriteLine("Item in an Array {0}",a[0]);
		String[] b = new String[] { "martin", "Valentine", "John" };
		Console.WriteLine($"Call {b[0]}");
		Object[] randomArray = new Object[] { 1, "Martin" };
		Console.WriteLine(randomArray.Length);
		
		String[,] Students= new String[2, 2] { {"Bob","John" },{"Valentine","Jane" } };
		Console.WriteLine(Students.GetValue(1,0));





	}
}
