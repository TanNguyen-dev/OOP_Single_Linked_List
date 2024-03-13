using System;

namespace LinkedList
{
    // Node class is defined as generic class to allow store any data type
    public class Node
    {
        // Data or value stored in the node.
        public object Data { get; set; }

        // Reference to the next node in the linked list.
        public Node Next { get; set; }

        // Node class constructor
        public Node(object data)
        {
            Data = data;
            Next = null;
        }
    }
}
