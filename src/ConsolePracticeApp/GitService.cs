using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ConsolePracticeApp
{
    public class GitService
    {
        private const string url = "https://api.github.com/";  

        public string username; 

        public GitService(string username)
        {
            this.username = username; 
        }

        public void getRepositories()
        {
            Console.WriteLine("repositories gotten");
            var client = new RestClient(url); 

            var request = new RestRequest("users/{username}/repos", Method.GET);
            Console.WriteLine("Who's repositories would you like to see?");
            string username = Console.ReadLine();
            request.AddUrlSegment("username", username); 
            request.AddHeader("user-agent", "nicholascm90");
            client.ExecuteAsync<List<Repository>>(request, response => {
                Console.WriteLine(response.Content);
                Console.WriteLine(response.Content.Count());
                var first = response.Data[0];

            });
        }


    }
}


