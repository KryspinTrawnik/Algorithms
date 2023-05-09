using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Binary_Trees
{
    public class MaxRootToLeafPathSum
    {
        public int MaxRootToLeafPathSumByRecusion(Node node) 
        {
            if (node == null) return int.MinValue;
            if(node.Left  == null && node.Right == null) return (int)node.Value;


            return (int)node.Value + Math.Max(MaxRootToLeafPathSumByRecusion(node.Left), MaxRootToLeafPathSumByRecusion(node.Right));
        }
    }
}
