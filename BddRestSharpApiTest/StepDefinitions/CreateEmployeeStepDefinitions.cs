namespace BddRestSharpApiTest.StepDefinitions
{
    #region Usings

    using RestSharp;

    using TechTalk.SpecFlow;
    using TechTalk.SpecFlow.Assist;

    using Context;
    using Models;

    #endregion

    [Binding]
    public class CreateEmployeeStepDefinitions
    {
        private ApiContext apiContext;

        public CreateEmployeeStepDefinitions(ApiContext apiContext)
        {
            this.apiContext = apiContext;
        }

        [Given(@"I have given data in JSON body:")]
        public void GivenIHaveGivenDataToJsonBody(Table table)
        {
            apiContext.Request.RequestFormat = DataFormat.Json;

            var employeeData = table.CreateInstance<EmployeeCreate>();
            apiContext.Request.AddJsonBody(employeeData);
        }

        [Given(@"I have empty JSON body")]
        public void GivenIHaveEmptyJsonBody()
        {
            apiContext.Request.RequestFormat = DataFormat.Json;
            apiContext.Request.AddJsonBody("{}");
        }
    }
}