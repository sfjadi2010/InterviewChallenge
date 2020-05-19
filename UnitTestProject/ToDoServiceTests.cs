using System.Linq;
using InterviewChallenge.Services;
using Microsoft.AspNetCore.Mvc;
using UnitTestProject.ChallengeSolutions;
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
            //Assert.Equal("delectus aut autem", results.First().title);
        }

        [Fact]
        public void GetAllCompletedTest()
        {
            var service = new ToDoService();
            var results = service.GetAllCompleted();
            Assert.Equal(90, results.Count);
            //Assert.True(results.First().completed);
        }

        [Fact]
        public void GetIncompleteForUserTest()
        {
            var service = new ToDoService();
            var results = service.GetIncompleteForUser(5);
            Assert.Equal(8,results.Count);
            //Assert.Equal(5, results.First().userId);
        }
    }
}