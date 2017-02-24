using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsolePracticeApp
{
    public class GitService
    {
        public const string url = "https://api.github.com/search/repositories?q=";  

        public string username; 

        public GitService(string username)
        {
            this.username = username; 
        }

        public void getRepositories()
        {
            Console.WriteLine("repositories gotten"); 
            
        }
    }
}


