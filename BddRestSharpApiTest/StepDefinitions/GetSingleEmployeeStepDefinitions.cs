namespace BddRestSharpApiTest.StepDefinitions
{
    #region Usings

    using FluentAssertions;

    using TechTalk.SpecFlow;

    using Context;
    using Extensions;
    using Models;

    #endregion

    [Binding]
    public class GetSingleEmployeeStepDefinitions
    {
        private ApiContext apiContext;

        private Employee responseData;

        public GetSingleEmployeeStepDefinitions(ApiContext apiContext)
        {
            this.apiContext = apiContext;
        }

        private Employee GetResponseData
        {
            get
            {
                if (responseData is null)
                {
                    responseData = apiContext.Response.TryGetObjectOfType<ApiResponse<Employee>>().Data;
                }

                return responseData;
            }
        }

        [Then(@"GET response for employee id should be (.*)")]
        public void ThenReturnedEmployeeIdShouldBe(int expectedEmployeeId)
        {
            GetResponseData.Id.Should().Be(expectedEmployeeId);
        }

        [Then(@"GET response for employee salary should be (.*)")]
        public void ThenReturnedEmployeeSalaryShouldBe(int expectedSalary)
        {
            GetResponseData.Salary.Should().Be(expectedSalary);
        }

        [Then(@"GET response for employee age should be (.*)")]
        public void ThenReturnedEmployeeAgeShouldBe(int expectedAge)
        {
            GetResponseData.Age.Should().Be(expectedAge);
        }

        [Then(@"GET response for profile image should be ""(.*)""")]
        public void ThenReturnedProfileImageShouldBe(string expectedProfileImage)
        {
            GetResponseData.ProfileImage.Should().Be(expectedProfileImage);
        }

        [Then(@"GET response for employee name should be (.*)")]
        public void ThenReturnedEmployeeNameShouldBe(string expectedName)
        {
            GetResponseData.Name.Should().Be(expectedName);
        }

        [Then(@"GET response data should not be empty")]
        public void ThenGetResponseDataShouldNotBeEmpty()
        {
            GetResponseData.Should().NotBeNull();
            GetResponseData.Age.Should().NotBe(default(int));
            GetResponseData.Id.Should().NotBe(default(int));
            GetResponseData.Salary.Should().NotBe(default(int));
            GetResponseData.Name.Should().NotBeNull();
            GetResponseData.ProfileImage.Should().NotBeNull();
        }
    }
}