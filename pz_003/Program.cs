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

        //  должен быть прямой (preorder)
        static void GoToUnderGround(TreeNode x)
        {
            if(x != null)
            {
                Console.WriteLine(x.Info);
                if (x.Left != null) GoToUnderGround(x.Left);
                if (x.Right != null) GoToUnderGround(x.Right);
            }
        }

        //  должен быть симметричный (inorder)
        static void InUnderGround(TreeNode x, int lvl = 0)
        {
            int currentLvl = lvl;

            if(x!=null)
            {
                lvl++;
                if(x.Left!=null) InUnderGround(x.Left, lvl);
                for (int i = 0; i < lvl-1; i++) Console.Write("\t");
                Console.WriteLine(x.Info);
                if (x.Right != null) InUnderGround(x.Right, lvl);
            }
        }

        //   не обязан но может быть обратный
        static void PostUnderGround(TreeNode x)
        {
            string tempXR=String.Empty;
            string tempXL=String.Empty;
            string tempXX=String.Empty;

            

            if(x!=null)
            {
                bool tempL = x.Left != null;
                bool tempR = x.Right != null;

                if (tempL)
                {
                    tempXR += !tempR ? "null" : x.Right.Info;
                    Console.WriteLine(tempXX + tempXL + tempXR);
                    PostUnderGround(x.Left);
                    
                }

                if (tempR)
                {
                    tempXL += !tempL ? "null" : x.Left.Info;
                    Console.WriteLine(tempXX + tempXL + tempXR);
                    PostUnderGround(x.Right);
                    
                }


            }
        }

        /*  в итоге они отличаются лишь порядком вывода ☺☺☺☺☺☺☺☺☺
            и конкретно с последним вариантом что то не так */

        static void Main(string[] args)
        {
            BinaryTree tree = new();

            int countNode;
            Console.Write("size: ");
            if (int.TryParse(Console.ReadLine(), out countNode))
            {            
                Console.Clear();
                tree.Root = Trees.CreateBalanced(countNode);
            }
            else tree.Root = Trees.CreateBalanced(0);


            InUnderGround(tree.Root);
        }
    }
}