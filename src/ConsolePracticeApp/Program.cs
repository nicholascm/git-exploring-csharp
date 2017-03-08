using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net; 

namespace ConsolePracticeApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.PrintAllNodes();
            Console.WriteLine();
            list.AddAtLast("1");
            list.AddAtLast("2");
            list.AddAtLast("3");
            list.AddAtLast("4");
            list.AddAtLast("5");
            list.AddAtLast("6");
            list.PrintAllNodes();
            Console.WriteLine();
            Console.WriteLine("Remove last");

            list.RemoveLastNode();
            list.PrintAllNodes();
            Console.WriteLine();
            Console.WriteLine("Remove at position 3");

            list.RemoveAtPostion(3);
            list.PrintAllNodes();
            Console.ReadLine(); 
        }
    }
}
