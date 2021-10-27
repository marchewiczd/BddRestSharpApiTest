namespace BddRestSharpApiTest.StepDefinitions
{
    #region Usings

    using System.Collections.Generic;
    using System.Linq;

    using FluentAssertions;

    using TechTalk.SpecFlow;

    using Context;
    using Extensions;
    using Models;

    #endregion

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
            var responseData = apiContext.Response.TryGetObjectOfType<ApiResponse<List<Employee>>>().Data;

            responseData.Should().NotBeNull();
            responseData.Should().BeOfType(typeof(List<Employee>));
            responseData.Any().Should().BeTrue();
        }
    }
}