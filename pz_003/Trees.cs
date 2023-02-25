namespace pz_003
{
    internal static class Trees
    {
        //   ветка бинарного дерева ()уравновешенного, может быть даже идеально сбалансированного
        public static TreeNode CreateBalanced(int n)
        {
            char x;
            TreeNode root;

            if (n == 0) root = null;
            else
            {
                Console.Write("info (char):");
                x = char.Parse(Console.ReadKey().Key.ToString());
                root = new TreeNode(x);
                root.Left = CreateBalanced(n / 2);
                root.Right = CreateBalanced(n - n / 2 - 1);
            }

            return root;
        }
    }
}
