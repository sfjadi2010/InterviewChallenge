﻿using System.Linq;
using InterviewChallenge.Services;
using Microsoft.AspNetCore.Mvc;
//using UnitTestProject.ChallengeSolutions;
using Xunit;

namespace UnitTestProject
{
    public class ToDoServiceTests
    {
        [Fact]
        public void GetAllTest()
        {
            var service = new ToDoService();
            var results = service.GetAll();
            Assert.Equal(200, results.Count);
            Assert.Equal("delectus aut autem", results.First().Title);
        }

        [Fact]
        public void GetAllCompletedTest()
        {
            var service = new ToDoService();
            var results = service.GetAllCompleted();
            Assert.True(results.First().Completed);
        }

        [Fact]
        public void GetIncompleteForUserTest()
        {
            var service = new ToDoService();
            var results = service.GetIncompleteForUser(5);
            Assert.Equal(8,results.Count);
            Assert.Equal(5, results.First().UserId);
            Assert.False(results.First().Completed);
        }
    }
}