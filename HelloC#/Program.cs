// See https://aka.ms/new-console-template for more information

namespace HelloC
    {
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello leon");
//changing console color
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
        }
    }

}
