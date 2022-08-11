using System;
namespace LeedCodeLove.LeedCodeL1
{
    public static class ValidateBinarySearchTree
    {
        public static bool IsValidBST(TreeNode root)
        {
            return IsValid(root, Decimal.MinValue, Decimal.MaxValue);
        }

        private static bool IsValid(TreeNode node, Decimal left, Decimal right)
        {
            if (node == null)
                return true;
            if (!(node.val < right && node.val > left))
                return false;

            return IsValid(node.left, left, node.val) && IsValid(node.right, node.val, right);
        }
    }
}
