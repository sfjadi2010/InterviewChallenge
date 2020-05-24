using InterviewChallenge.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace InterviewChallenge.Services
{
    public class ToDoHttpClient : IToDoHttpClient
    {
        private readonly IConfiguration _configuration;

        public ToDoHttpClient()
        {
            _configuration = new ConfigurationBuilder()
                                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                                .Build();
        }
        public async Task<List<ToDoItem>> GetAsync(string requestUri)
        {
            var apiUrl = _configuration.GetValue<string>("ToDosUrl");
            var uri = $"{apiUrl}?{requestUri}";

            List<ToDoItem> toDoItems = new List<ToDoItem>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(uri))
                {
                    string apiReponse = await response.Content.ReadAsStringAsync();
                    toDoItems = JsonConvert.DeserializeObject<List<ToDoItem>>(apiReponse);
                }
            }

            return toDoItems;
        }
    }
}
