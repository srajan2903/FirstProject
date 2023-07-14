using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack stack = new Stack();
            //stack.Push("Srajan");
            //stack.Push("Rahul");
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //stack.Pop();
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Peek example \t" + stack.Peek());
            //Queue queue = new Queue();
            //queue.Enqueue("Srajan");
            //queue.Enqueue("Rahul");
            //queue.Enqueue("Sameera");
            //Console.WriteLine("Number of items in Queue \t"+queue.Count);
            //Console.WriteLine("Stored values in Queue");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            //queue.Dequeue();
            //Console.WriteLine("After Dequeueing");
            //Console.WriteLine("Number of elements\t" + queue.Count);
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(" Peek example \t" + queue.Peek());
            //Console.WriteLine("Number of items in queue\t" + queue.Count);
            ArrayList fruits = new ArrayList();
            fruits.Add("apple");
            fruits.Add("banana");
            fruits.Add("cherry");
            fruits.Add("date");
            fruits.Add("elderberry");

            Console.WriteLine("Total number of elements in the ArrayList are \t" + fruits.Count);
            PrintArrayList(fruits);
            Console.WriteLine("Array List contains 'date' " + Search(fruits, "date"));
            InsertAtPosition(fruits, "fig", 1);
            RemoveElement(fruits, "banana");
            PrintArrayList(fruits);
            Console.ReadKey();
        }
        static void PrintArrayList(ArrayList list)
        {
            Console.WriteLine("Elements in the array list");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        static bool Search(ArrayList list, object element) { 
            return list.Contains(element);
        }
        static void InsertAtPosition(ArrayList list, object element, int position)
        {
            list.Insert(position, element);
        }
        static void RemoveElement(ArrayList list, object element)
        {
            list.Remove(element);
        }
    }
}
