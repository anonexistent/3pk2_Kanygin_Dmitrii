using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_003
{
    internal class BinaryTree
    {
		private TreeNode root;

		public TreeNode Root
		{
			get { return root; }
			set { root = value; }
		}
		public BinaryTree()
		{
			Root = null;
		}
	}
}
