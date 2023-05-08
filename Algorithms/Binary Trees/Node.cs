namespace Algorithms.Binary_Trees
{
    public class Node
    {
        public Object Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        
        public Node(Object value) 
        {
            Value = value;
            Left = null;
            Right = null;
        }

    }
}