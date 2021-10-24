using System.Collections.Generic;
using System.Linq;
using BddRestSharpApiTest.Context;
using BddRestSharpApiTest.Extensions;
using BddRestSharpApiTest.Models;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace BddRestSharpApiTest.StepDefinitions
{
    [Binding]
    public class GetAllEmployeesStepDefinitions
    {
        private ApiContext apiContext;

        public GetAllEmployeesStepDefinitions(ApiContext apiContext)
        {
            this.apiContext = apiContext;
        }

        [Then(@"returned data should be non empty list of employees")]
        public void ThenReturnedDataShouldBeNonEmptyListOfEmployees()
        {
            var response = apiContext.Response.TryGetObjectOfType<ApiResponse<List<Employee>>>();
            (response.Data is List<Employee> && response.Data.Any()).Should().BeTrue();
        }
    }
}