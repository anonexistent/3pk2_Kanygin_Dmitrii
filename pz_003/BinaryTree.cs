﻿namespace pz_003
{
    internal class BinaryTree
    {
		//	node	
		private TreeNode root;

		public TreeNode Root
		{
			get { return root; }
			set { root = value; }
		}
		private List<TreeNode> treeNodes;
		public BinaryTree()
		{
			Root = null;
		}

		public List<TreeNode> ToArray()
		{


			return treeNodes;
		}
	}
}
