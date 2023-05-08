using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Binary_Trees
{
    public class TreeIncludes
    {
        public bool DoesTreeIncludeBF(Node node, string target)
        {
            if (node == null || target == null) 
                return false;
            
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                Node current = queue.Dequeue();
                if((string)current.Value == target) return true;
                if(current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }
                if(current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }
            
            return false;
        }

        public bool DoesTreeIncludeRecusivly(Node node, string target)
        {
            if (node == null || target == null)
                return false;
            if(target.Equals(node.Value))
            {
                return true;
            }
            return DoesTreeIncludeRecusivly(node.Left, target) || DoesTreeIncludeRecusivly(node.Right, target);
        }

    }
}
