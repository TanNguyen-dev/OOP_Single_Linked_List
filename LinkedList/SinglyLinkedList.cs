using System;
using System.Collections.Generic;

namespace LinkedList
{
    // Singly Linked List (SLL) Class
    public class SinglyLinkedList : ISinglyLinkedListADT
    {
        // Define refernce/pointer to the first node
        private Node head;
        private int listSize;

        // SLL class constructor 
        // Create empty list
        public SinglyLinkedList()
        {
            head = null;
        }

        /******************  Checking the size *******************/
        // Implementation of IsEmpty() method for SLL
        // Checks if the list is empty.
        //return True if it is empty.
        public bool IsEmpty()
        {
            if (head is null)
            {
                return true;
            }
            return false;

            /*
            if (listSize == 0)
            {
                return true;
            }
            return false;
             
            */
        }

        // Implementation of Size() method for SLL
        // Return the size of the SLL
        public int Size()
        {
            if (head is null)
            {
                return 0;
            }
            return listSize;
        }

        /******************  Addition or insertion *******************/
        // Implementation of AddFirst() or Prepend method for SLL
        // Add node at the beginning of SLL
        // data ==> data to be added
        public void AddFirst(object data)
        {            
            // Create new node for data
            Node newNode = new Node(data);
            // Set the new node reference to the current head
            newNode.Next = head;
            // Update head to point to the new node
            head = newNode;

            // Increase the list size by 1
            listSize++;
        }

        // Implementation of AddLast() or Append method for SLL
        // Add node at the end of SLL
        // data => data to be added
        public void AddLast(object data)
        {
            // Create new node for data 
            Node newNode = new Node(data);

            if (head == null)  // Empty SLL
            {
                // Update head to point to the new node
                head = newNode;
                listSize++;
                return;
            }

            // Iterate through the SLL
            Node currentNode = head;
            while (currentNode.Next != null) // Loop until reaching null
            {
                // Go to the next node in the SLL
                currentNode = currentNode.Next;
            }

            // Update the reference of the last node to point to the new node
            // New node by default point to null (See Node class)
            currentNode.Next = newNode;

            // Increase the list size by 1
            listSize++;
        }

        // Implementation of AddBefore() method for SLL
        // Add node before certain node in SLL
        // searchNode => node to add before
        // data => data to be added
        public void AddBefore(Node searchNode, object data)
        {
            // Check argument
            if (searchNode == null)
            {
                throw new ArgumentNullException(nameof(searchNode), "The node to add cann't be null.");
            }

            // Create new node for data
            Node newNode = new Node(data);

            if (head == null)  // Empty SLL
            {
                // Increase the list size by 1
                listSize++;
                // Update head to point to the new node
                head = newNode;
                return;
            }

            // Navigate the SLL nodes
            Node currentNode = head;
            while (currentNode.Next != null)
            {
                // Find node before searchNode
                if (currentNode.Data.Equals(searchNode.Data))
                {
                    // Increase the list size by 1
                    listSize++;

                    // Insert the new node before searchNode
                    // Update the next reference accordingly
                    newNode.Next = currentNode.Next;
                    currentNode.Next = newNode;
                    return;
                }

                currentNode = currentNode.Next;
            }

            // throw error to indicate that the specified node does not exist in the SLL.
            throw new InvalidOperationException("node does not exist in the list.");
        }

        // Implementation of AddAfter() method for SLL
        // Add node after certain node in SLL
        // searchNode => node to add after
        // data => data to be added
        public void AddAfter(Node searchNode, object data)
        {
            // Check argument
            if (searchNode == null)
            {
                throw new ArgumentNullException(nameof(searchNode), "The node to add cann't be null.");
            }

            // Create new node for data
            Node newNode = new Node(data);

            if (head == null)  // Empty SLL
            {
                // Increase the list size by 1
                listSize++;

                // Update head to point to the new node
                head = newNode;
                return;
            }

            // Navigate the SLL nodes
            Node currentNode = head;
            while (currentNode != null)
            {
                // Find searchNode
                if (currentNode.Data.Equals(searchNode.Data))
                {
                    // Increase the list size by 1
                    listSize++;

                    // Insert the new node after searchNode
                    // Update the next reference accordingly
                    newNode.Next = currentNode.Next;
                    currentNode.Next = newNode;
                    return;
                }

                currentNode = currentNode.Next;
            }

            // throw error to indicate that the specified node does not exist in the SLL.
            throw new InvalidOperationException("node does not exist in the list.");
        }

        /******************  Removing or deleting *******************/
        // Implementation of RemoveFirst() method for SLL
        // Remove the first node from SLL
        public void RemoveFirst()
        {
            
            if (head == null)       // Empty SLL
            {
                return;             // Nothing to do
            }

            // Update head to skip the first node and point ot next node
            // This will update the second node to be the first node
            head = head.Next;

            // Decrease the list size by 1
            listSize--;
        }

        // Implementation of RemoveLast() method for SLL
        // Remove the last node from SLL
        public void RemoveLast()
        {
            if (head == null)       // Empty SLL
            {
                return;             // Nothing to do
            }

            if (head.Next == null)  // Only one node in the SLL
            {
                head = null;        // Set head to null
                return;
            }

            // Navigate the SLL using two references
            // One for current node and the other for previous node
            Node previousNode = null;    // Keep track for the node before the current node
            Node currentNode = head;     // Representing the current node being evaluated.
            while (currentNode.Next != null)
            {
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }

            // After loop finishs, update the previous to point to null
            // like that, you skipped the last node
            previousNode.Next = null;

            // Decrease the list size by 1
            listSize--;
        }

        // Implementation of Remove() method for SLL
        // Remove certain node from SLL
        // nodeToRemove => the node to be removed
        public void Remove(object nodeToRemove)
        {
            // Check argument
            if (nodeToRemove == null)
            {
                throw new ArgumentNullException(nameof(nodeToRemove), "The node to remove cann't be null.");
            }

            if (head == null)   // Empty SLL
            {
                return;         // Nothing to do
            }

            // Navigate the SLL using two references
            // One for current node and the other for previous node
            Node previousNode = null;    // Keep track for the node before the current node
            Node currentNode = head;     // Representing the current node being evaluated.
            while (currentNode != null)
            {
                // Check if the current node is the node to be removed
                if (currentNode.Data.Equals(nodeToRemove))
                {
                    // Decrease the list size by 1
                    listSize--;

                    // Update the previous node reference to point to the next next node
                    // This to remove the current node
                    previousNode.Next = currentNode.Next;
                    return;
                }

                // Keep looping
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }

            // throw error to indicate that the specified node does not exist in the SLL.
            throw new InvalidOperationException("The node to remove does not exist in the list.");
        } 

        // Implementation of Clear() method for SLL
        // Remove all node from SLL
        public void Clear()
        {
            head = null;
            listSize = 0;
        }

        /******************  Convert and display *******************/
        // Implementation of ToList() method for SLL
        // Convert SLL to list
        // Return the list for SLL
        public List<object> ToList()
        {
            // Create list of data (not nodes)
            List<object> list = new List<object>();
            Node currentNode = head;

            while (currentNode != null)
            {
                list.Add(currentNode.Data);
                currentNode = currentNode.Next;
            }

            return list;
        }

        // Implementation of ToString() method for SLL
        // Form one string for nodes' data in SLL
        // Return string for the nodes' data in SLL
        public override string ToString()
        {
            string myString = string.Empty; // Create an empty list

            // Iterate through the SLL
            Node currentNode = head;
            while (currentNode != null)
            {
                myString += currentNode.Data.ToString();

                if (currentNode.Next != null)
                {
                    myString += " -> ";
                }
                currentNode = currentNode.Next;
            }

            return myString;
        }

        // Implementation of Display() method for SLL
        // Dispaly all nodes' data in SLL
        public void Display()
        {
            // Iterate or traverse through the SLL
            Node currentNode = head;
            while (currentNode != null)
            {
                // Perform operations on the current node
                Console.Write(currentNode.Data + " ");

                // Move to the next node
                currentNode = currentNode.Next;
            }

            Console.WriteLine();
        }
    }
}