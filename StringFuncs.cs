using System;

public class StringFuncs
{
	public static void Strigfunc()
	{

		String greeting = "Hello martin, How are you today";
		Console.WriteLine(greeting);
		Console.WriteLine("String length {0}",greeting.Length);
		Console.WriteLine("Mentioed 'martin'? {0}",greeting.Contains("martin"));
		Console.WriteLine("Where is 'martin'? {0}",greeting.IndexOf("martin"));
		int wherIs =greeting.IndexOf("martin");
        Console.WriteLine("Remonve martin {0}",greeting.Remove(wherIs));
		Console.WriteLine("Add Jane {0}", greeting.Insert(wherIs, "jane"));
		Console.WriteLine("Replace Hello {0}", greeting.Replace("Hello", "Hi"));



	}
}
