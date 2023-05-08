using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Binary_Trees
{
    public class CreateBinaryTree
    {
        public Node GetBinaryTreeFromArrayByRecursion(object[] arr, int start, int end)
        {
            if(start > end)
            {
                return null;
            }
            int mid = (start + end) / 2;
            Node root = new(arr[mid]);
            root.Left = GetBinaryTreeFromArrayByRecursion((object[])arr, start, mid -1);
            root.Right = GetBinaryTreeFromArrayByRecursion((object[])arr,mid + 1, end);
            
            return root;
        }

        public Node GetBinaryTreeFromArrayByIteretion(object[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return null;
            }
            Node root = new(arr[0]);
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            int L = arr.Length;
           for(int i  = 1; i < L; i+= 2) 
           {
                Node node = queue.Dequeue();
                node.Left = new(arr[i]);
                queue.Enqueue(node.Left);
                if(i +1 < L)
                {
                    node.Right = new(arr[i+1]);
                    queue.Enqueue(node.Right);
                }
                if (i + 2 > L)
                    break;
            }

           return root;
        }

    }
}
