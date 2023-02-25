namespace pz_003
{
    internal class Program
    {
        static void Print(object a)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(a.ToString());
            Console.ResetColor();
        }

        static void Main(string[] args)
        {

        }
    }
}