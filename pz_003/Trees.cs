﻿namespace pz_003
{
    internal static class Trees
    {
        //   ветка бинарного дерева ()уравновешенного, может быть даже идеально сбалансированного
        public static TreeNode CreateBalanced(int n)
        {
            int x;
            TreeNode root;

            if (n == 0) root = null;
            else
            {
                Console.Write($"info {n} (char):");
                x = int.Parse(Console.ReadLine());
                Console.Clear();
                root = new TreeNode(x);
                root.Left = CreateBalanced(n / 2);
                root.Right = CreateBalanced(n - n / 2 - 1);
            }

            return root;
        }

        #region TravelingInTree
            //static void InUnderGround(TreeNode x, int lvl = 0)
            //{
            //    int currentLvl = lvl;

            //    if (x != null)
            //    {
            //        lvl++;
            //        if (x.Left != null) InUnderGround(x.Left, lvl);
            //        for (int i = 0; i < lvl - 1; i++) Console.Write("\t");
            //        Console.WriteLine(x.Info);
            //        if (x.Right != null) InUnderGround(x.Right, lvl);
            //    }
            //}
        #endregion


        public static int AvgInfo(TreeNode x, int currentAvg = 0)
        {
            int o = currentAvg;

            if (x != null)
            {
                o += x.Info;
                if (x.Left != null) AvgInfo(x.Left, o);
                if (x.Right != null) AvgInfo(x.Right, o);
                
            }
            if (x == null) return o;
        }
    }
}
