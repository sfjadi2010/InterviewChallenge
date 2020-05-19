using System.Collections.Generic;
using InterviewChallenge.Models;

namespace InterviewChallenge.Services
{
    public interface IToDoService
    {
        List<ToDoItem> GetAll();
        List<ToDoItem> GetAllCompleted();
        List<ToDoItem> GetIncompleteForUser(int id);
    }
}