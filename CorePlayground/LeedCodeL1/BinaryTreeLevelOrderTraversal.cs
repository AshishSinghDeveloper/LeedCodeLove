using System;
using System.Collections.Generic;

namespace LeedCodeLove.LeedCodeL1
{
	public class TreeNode
	{
		public int val;
		public TreeNode left;
		public TreeNode right;
		public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
		{
			this.val = val;
			this.left = left;
			this.right = right;
			}
	}
	public static class BinaryTreeLevelOrderTraversal
    {
		public static IList<IList<int>> LevelOrder(TreeNode root)
		{
			var result = new List<IList<int>>();
			if (root == null) return result;
			var nodeQ = new Queue<TreeNode>();
			nodeQ.Enqueue(root);
			while (nodeQ.Count != 0)
			{
				int qSize = nodeQ.Count;
				var currentLevel = new List<int>();
				for (int i = 0; i < qSize; i++)
				{
					var currentNode = nodeQ.Dequeue();
					if (currentNode.left != null) nodeQ.Enqueue(currentNode.left);
					if (currentNode.right != null) nodeQ.Enqueue(currentNode.right);
					currentLevel.Add(currentNode.val);
				}
				result.Add(currentLevel);
			}
			return result;
		}
	}
}
