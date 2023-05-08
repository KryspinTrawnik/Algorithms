using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Binary_Trees
{
    public class DepthFirstValues
    {
        public List<Object> DepthFirstValuesByRecursion(Node node, List<Object> result)
        {
            if (node == null)
                return result;
            result.Add(node.Value);
            DepthFirstValuesByRecursion(node.Left, result);
            DepthFirstValuesByRecursion(node.Right, result);

            return result;
        }

        public List<Object> DepthFirstValuesByIteration(Node root)
        {
            if (root == null)
                return null;
            List<object> result = new();   
            Stack<Node> stack = new Stack<Node>();
            stack.Push(root);
            while (stack != null) 
            { 
                Node current = stack.Pop();
                result.Add(current.Value);
                stack.Push(current.Left);
                stack.Push(current.Right);
            }

            return result;
        }
    }
}
