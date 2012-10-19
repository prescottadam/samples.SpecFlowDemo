using System;
using TechTalk.SpecFlow;

namespace samples.SpecFlowDemo.SpecFlow
{
    [Binding]
    public class Person_AddAndUpdateSteps : Steps
    {
        [Given(@"I created and saved a person record with the following properties")]
        public void GivenICreatedAndSavedAPersonRecordWithTheFollowingProperties(Table table)
        {

            Given("I have a new person record with the following properties", table);
            When("I save the person");
        }
    }
}
