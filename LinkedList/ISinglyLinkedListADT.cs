using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    // Interface for Singly Linked List (SLL) Abstract Data Type (ADT) 
    public interface ISinglyLinkedListADT
    {
        /******************  Checking the size *******************/
        //Checks if the list is empty.
        bool IsEmpty();
        // Gets the number of elements in the list.
        int Size();

        /******************  Addition or insertion *******************/
        // Add node at the beginning of SLL
        void AddFirst(object data);
        // Add node at the end of SLL
        void AddLast(object data);
        // Add node after certain node in SLL
        void AddAfter(Node searchNode, object data);
        // searchNode => node to add before
        void AddBefore(Node searchNode, object data);

        /******************  Removing or deleting *******************/
        // Remove the first node from SLL
        void RemoveFirst();
        // Remove the last node from SLL
        void RemoveLast();
        // Remove certain node from SLL
        void Remove(object nodeToRemove);
        // Remove node at certain index from SLL
        void Clear();

        /******************  Convert and display *******************/
        // Convert SLL to list
        List<object> ToList();
        // Form one string for nodes' data in SLL
        string ToString();
        // Dispaly all nodes' data in SLL
        void Display();
    }
}
