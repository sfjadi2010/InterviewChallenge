using InterviewChallenge.Models;
using InterviewChallenge.Services;
using System;
using System.Collections.Generic;
using RestSharp;
using System.Text;

namespace UnitTestProject.ChallengeSolutions
{
    public class ToDoServiceSolution : IToDoService
    {
        public List<ToDoItem> GetAll()
        {
            var client = new RestClient("https://jsonplaceholder.typicode.com/todos");
            var request = new RestRequest(Method.GET);
            var response = client.Execute<List<ToDoItem>>(request);
            return response.Data;
        }

        public List<ToDoItem> GetAllCompleted()
        {
            var client = new RestClient($"https://jsonplaceholder.typicode.com/todos");
            var request = new RestRequest(Method.GET);
            request.AddParameter("completed", "true");
            var response = client.Execute<List<ToDoItem>>(request);
            return response.Data;
        }

        public List<ToDoItem> GetIncompleteForUser(int id)
        {
            var client = new RestClient($"https://jsonplaceholder.typicode.com/todos");
            var request = new RestRequest(Method.GET);
            request.AddParameter("userId", id);
            request.AddParameter("completed", "false");
            var response = client.Execute<List<ToDoItem>>(request);
            return response.Data;
        }
    }
}
