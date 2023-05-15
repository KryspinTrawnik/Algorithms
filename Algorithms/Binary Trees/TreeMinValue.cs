using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Binary_Trees
{
    public class TreeMinValue
    {
        public int GetTreeMinValueBF(Node node) 
        {
            if (node == null)
               return 0;
           
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);
            int min  = int.MaxValue;

            while (queue.Count >0) {
            
                Node current = queue.Dequeue();
                if((int)current.Value < min)
                {
                    min = (int)current.Value;
                }
                if(current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }
                if(current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }

            return min;
        }

        public int GetTreeMinValueRecursivly(Node node) 
        {
            if (node == null)
                return int.MaxValue;

            return Math.Min((int)node.Value, Math.Min(GetTreeMinValueRecursivly(node.Left), GetTreeMinValueRecursivly(node.Right)));
        }
    }

}
