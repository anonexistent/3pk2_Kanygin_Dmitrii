using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_003
{
    internal class TreeNode
    {
		private char info;

		public char Info
		{
			get { return info; }
			set { info = value; }
		}

		private TreeNode left;

		public TreeNode Left
		{
			get { return left; }
			set { left = value; }
		}
		private TreeNode right;

		public TreeNode Right
		{
			get { return right; }
			set { right = value; }
		}

		public TreeNode()
		{

		}
		public TreeNode(char info)
		{
			Info=info;
		}
		public TreeNode(char info, TreeNode left, TreeNode right)
		{
			Info = info;
			Left = left;
			Right = right;
		}
	}
}
