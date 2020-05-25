using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using InterviewChallenge.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace InterviewChallenge.Services
{
    public class ToDoService : IToDoService
    {
        private readonly IToDoHttpClient _httpClient;
        public ToDoService(IToDoHttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public List<ToDoItem> GetAll()
        {
            return _httpClient.GetAsync("").Result;
        }

        public List<ToDoItem> GetAllCompleted()
        {
            return _httpClient.GetAsync($"completed=true").Result;
        }

        public List<ToDoItem> GetIncompleteForUser(int id)
        {
            return _httpClient.GetAsync($"completed=false&userId={id}").Result;
        }
    }
}
