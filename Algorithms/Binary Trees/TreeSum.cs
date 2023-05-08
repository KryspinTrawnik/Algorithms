using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Binary_Trees
{
    public class TreeSum
    {
        public int GetSumOfTreeByBreadthFirstValues(Node node)
        {
            if (node == null)
                return 0;
            int sum = 0;
            Queue<Node> queue = new Queue<Node>();
            while (queue.Count > 0)
            {
                Node current = queue.Dequeue();
                sum += (int)current.Value;
                if (current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }
                if (current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }

            return sum;
        }
        public int GetSumOfTreeByDepthInValues(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            int sum = 0;
            Stack<Node> stack = new Stack<Node>();
            stack.Push(node);
            while (stack.Count > 0)
            {
                Node currentNode = stack.Pop();
                sum += (int)currentNode.Value;
                if (currentNode.Left != null)
                {
                    stack.Push(currentNode.Left);
                }
                if (currentNode.Right != null)
                {
                    stack.Push(currentNode.Right);
                }
            }
            return sum;

        }

        public int GetSumOfTreeByRecursion(Node node)
        {
            if (node == null)
            {
                return 0;
            }
           
            return (int)node.Value + GetSumOfTreeByRecursion(node.Left) + GetSumOfTreeByRecursion(node.Right);
        }
    }
}
