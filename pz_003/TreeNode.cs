namespace pz_003
{
    internal class TreeNode
    {
		private int info;

		public int Info
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
		public TreeNode(int info)
		{
			Info=info;
		}
		public TreeNode(int info, TreeNode left, TreeNode right)
		{
			Info = info;
			Left = left;
			Right = right;
		}
	}
}
