using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The list");
            SinglyLinkedList intLinkedList = new SinglyLinkedList();

            Console.WriteLine("\nIsEmpty");
            Console.WriteLine("Empty SLL: {0}", intLinkedList.IsEmpty());

            for (int i = 1; i <= 10; i++)
                intLinkedList.AddLast(i);

            Console.WriteLine("\nInitial List Items");
            intLinkedList.Display();  // Output: 1 to 10

            Console.WriteLine("\nIsEmpty");
            Console.WriteLine("Empty SLL: {0}", intLinkedList.IsEmpty());

            Console.WriteLine("\nAdd");
            Console.WriteLine();
            intLinkedList.AddFirst(0);
            Console.WriteLine("Afetr adding 0 as first");
            intLinkedList.Display();    // Output: 0 1 2 3 4 5 6 7 8 9 10           
            intLinkedList.AddLast(11);
            Console.WriteLine("Afetr adding 11 as last");
            intLinkedList.Display();    // Output: 0 1 2 3 4 5 6 7 8 9 10 11           

            Console.WriteLine("\nRemove");
            intLinkedList.RemoveFirst();
            Console.WriteLine("Afetr removing first item (0)");
            intLinkedList.Display(); // Output: 1 2 2 3 4 5 6 6 7 8 9 10 11
            intLinkedList.RemoveLast();
            Console.WriteLine("Afetr removing last item (11)");
            intLinkedList.Display(); // Output: 1 2 2 3 4 5 6 6 7 8 9 10

            Console.WriteLine();
            intLinkedList.Remove(2);  // the first occurance
            Console.WriteLine("Afetr removing 2");
            intLinkedList.Display(); // Output: 1 3 4 5 6 7 8 9 10           
            intLinkedList.Remove(6);  // the first occurance
            Console.WriteLine("Afetr removing 6");
            intLinkedList.Display(); // Output: 1 3 4 5 7 8 9 10           

            Console.WriteLine("\nTo String");
            Console.WriteLine(intLinkedList.ToString());    // Output: 1 -> 3 -> 4 -> 5 -> 7 -> 8 -> 9 -> 10

            Console.WriteLine("\nSize");
            Console.WriteLine(intLinkedList.Size());  // Output: 8

            Console.ReadKey();
        }
    }
}
