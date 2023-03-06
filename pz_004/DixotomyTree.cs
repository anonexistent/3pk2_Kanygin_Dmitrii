namespace pz_004
{
    internal class DixotomyTree
    {
		private DTreeNode root;

		public DTreeNode Root
		{
			get { return root; }
			set { root = value; }
		}
		public DixotomyTree(DTreeNode start)
		{
			root = start;
		}
        public static DTreeNode Insert_DNode(DTreeNode root, DTreeNode k)
        {
            if (root == null) root = k;
            else
            {
                if (k.Key < root.Key) root.Left = Insert_DNode(root.Left, k);
                else if (k.Key > root.Key) root.Right = Insert_DNode(root.Right, k);
                else Console.WriteLine("eror: !(unique key)");
            }

            return root;
        }

        public static void InfoSum(DTreeNode x, List<char> a)
        {
            a.Add(x.Info);

            if (x.Right != null)
            { 
                InfoSum(x.Right,a); 
            }
            if (x.Left != null)
            {
                InfoSum(x.Left,a);
            }
        }

        public static int HowMuchBenchInTheTree(DTreeNode x)
        {
            if (x == null || (x.Left == null && x.Right == null)) return 0;
            else return 1 + HowMuchBenchInTheTree(x.Left) + HowMuchBenchInTheTree(x.Right);            
        }

        
    }
}
