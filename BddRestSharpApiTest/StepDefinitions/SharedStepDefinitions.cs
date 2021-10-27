namespace BddRestSharpApiTest.StepDefinitions
{
    #region Usings

    using System.Net;

    using FluentAssertions;

    using RestSharp;

    using TechTalk.SpecFlow;

    using Context;
    using Extensions;
    using Models;

    #endregion

    [Binding]
    public class SharedStepDefinitions
    {
        private ApiContext apiContext;

        private EmployeeCreate? responseData;

        public SharedStepDefinitions(ApiContext apiContext)
        {
            this.apiContext = apiContext;
        }

        private EmployeeCreate GetResponseData
        {
            get
            {
                if (responseData is null)
                {
                    responseData = apiContext.Response.TryGetObjectOfType<ApiResponse<EmployeeCreate>>().Data;
                }

                return responseData;
            }
        }

        [Given(@"I create request to ""(.*)"" endpoint")]
        public void GivenICreateRequestToEndpoint(string endpointUrl)
        {
            apiContext.Request = new RestRequest(endpointUrl);
        }

        [When(@"I execute ""(.*)"" request")]
        public void WhenIExecuteRequest(Method requestType)
        {
            apiContext.Request.Method = requestType;
            apiContext.Response = apiContext.Client.Execute(apiContext.Request);
        }

        [Then(@"returned status code should be ""(.*)""")]
        public void ThenReturnedStatusCodeShouldBe(HttpStatusCode statusCode)
        {
            apiContext.Response.StatusCode.Should().Be(statusCode);
        }

        [Given(@"I add parameter ""(.*)"" of value ""(.*)""")]
        public void GivenIAddParameterOfValue(string parameterName, string parameterValue)
        {
            apiContext.Request.AddUrlSegment(parameterName, parameterValue);
        }

        [Then(@"response for employee salary should be (.*)")]
        public void ThenPostResponseForEmployeeSalaryShouldBe(string expectedSalary)
        {
            GetResponseData.Salary.Should().Be(expectedSalary);
        }

        [Then(@"response for employee age should be (.*)")]
        public void ThenPostResponseForEmployeeAgeShouldBe(string expectedAge)
        {
            GetResponseData.Age.Should().Be(expectedAge);
        }

        [Then(@"response for employee name should be ""(.*)""")]
        public void ThenPostResponseForEmployeeNameShouldBe(string expectedName)
        {
            GetResponseData.Name.Should().Be(expectedName);
        }
    }
}