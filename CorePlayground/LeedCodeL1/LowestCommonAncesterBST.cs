namespace LeedCodeLove.LeedCodeL1
{
    public static class LowestCommonAncesterBST
    {
        public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            var current = root;
            while (current != null)
            {
                if (p.val > current.val && q.val > current.val)
                {
                    current = current.right;
                }
                else if (p.val < current.val && q.val < current.val)
                {
                    current = current.left;
                }
                else
                {
                    return current;
                }

            }
            return current;
        }
    }
}
