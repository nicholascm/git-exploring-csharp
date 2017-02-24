using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ConsolePracticeApp
{
    public class GitService
    {
        private const string url = "https://api.github.com/search/repositories?q=";  

        public string username; 

        public GitService(string username, string url)
        {
            this.username = username; 
        }

        public void getRepositories()
        {
            Console.WriteLine("repositories gotten");
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponseAsync();

        }
    }
}


