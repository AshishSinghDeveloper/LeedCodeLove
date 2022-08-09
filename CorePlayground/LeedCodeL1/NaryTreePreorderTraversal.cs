using System;
using System.Collections.Generic;

namespace LeedCodeLove.LeedCodeL1
{
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }

    public static class NaryTreePreorderTraversal
    {
        public static IList<int> Preorder(Node root)
        {
            var result = new List<int>();
            if (root == null) return result;

            result.Add(root.val);
            GetChildren(result, root.children);
            return result;
        }
        private static void GetChildren(IList<int> result, IList<Node> nodesChild)
        {
            if (nodesChild == null) return;

            foreach (var node in nodesChild)
            {
                result.Add(node.val);
                GetChildren(result, node.children);
            }
        }
    }


}
