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
            Console.WriteLine("Hello World");
            var serv = new GitService("nicholascm90");
            serv.getRepositories();
            Console.ReadLine(); 
        }
    }
}
