using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static DTreeNode Insert_DNode(DTreeNode root, int k)
        {
            if (root == null) root = new DTreeNode(' ', k, null, null);
            else
            {
                if (k < root.Key) root.Left = Insert_DNode(root.Left, k);
                else if (k > root.Key) root.Right = Insert_DNode(root.Right, k);
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
    }
}
