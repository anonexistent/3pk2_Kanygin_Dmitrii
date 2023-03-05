namespace pz_004
{
    internal class Program
    {
        static Random uuu = new();

        static void Print(object a)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(a.ToString());
            Console.ResetColor();
        }

        static void Print_DTree(DTreeNode x, int lvl=0)
        {
            int currentLvl = lvl;

            if (x != null)
            {
                lvl++;
                if (x.Right != null) Print_DTree(x.Right, lvl);
                for (int i = 0; i < lvl; i++) Console.Write("\t");
                Console.WriteLine(x.Key.ToString());
                if (x.Left != null) Print_DTree(x.Left, lvl);
            }
        }

        static void Main(string[] args)
        {
            #region TreeCreating

            var tree = new DixotomyTree(new('0',uuu.Next(0,1001)));

            //  хорошая идея присваивать рандом (чар) 58-128

            List<int> a = new();

            Console.Write($"count>> ");

            int countLeafs = -1;
            int.TryParse(Console.ReadLine(), out countLeafs);

            for (int i = 0; i < countLeafs; i++)
            {
                
                var temp = new DTreeNode((char)uuu.Next(58,128), uuu.Next(0, 1001));
                if (!a.Contains(temp.Key))
                {
                    a.Add(temp.Key);
                    DixotomyTree.Insert_DNode(tree.Root, temp);
                }
                else i--;
            }

            Console.WriteLine("start with: {0}",tree.Root.Key+"\n\n");

            Print_DTree(tree.Root);

            Print($"\n\n{string.Join('—',a)}\n\n");

            #endregion

            #region CountLeefs

            var result1 = new List<char>();
            DixotomyTree.InfoSum(tree.Root, result1);

            Print(string.Join('—',result1));

            #endregion


        }
    }
}