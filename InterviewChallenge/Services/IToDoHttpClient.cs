﻿using InterviewChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace InterviewChallenge.Services
{
    public interface IToDoHttpClient
    {
        Task<List<ToDoItem>> GetAsync(string rquestUri);
    }
}
