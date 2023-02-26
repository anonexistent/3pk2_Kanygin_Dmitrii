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

        static void GoToUnderGround(BinaryTree x)
        {
            if(x.Root.Right != null || x.Root.Left != null)
            {
                Console.WriteLine(x.Root.Left.Info + x.Root.Right.Info);
            }
        }

        static void Main(string[] args)
        {
            BinaryTree tree = new();

            int countNode;
            if (int.TryParse(Console.ReadLine(), out countNode)) tree.Root = Trees.CreateBalanced(countNode);
            else tree.Root = Trees.CreateBalanced(0);


        }
    }
}