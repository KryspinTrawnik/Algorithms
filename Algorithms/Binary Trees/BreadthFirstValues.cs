using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Binary_Trees
{
    public class BreadthFirstValues
    {
        public object[] GetBreadthFirstValues(Node node)
        {
            if (node == null)
                return Array.Empty<object>();

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);
            List<object> result = new List<object>();
            while (queue.Count > 0)
            {
                Node current = queue.Dequeue();
                result.Add(current.Value);
                if (current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }
                if (current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }

            return result.ToArray();
        }
    }
}
