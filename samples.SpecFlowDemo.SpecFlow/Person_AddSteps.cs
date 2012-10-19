using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace samples.SpecFlowDemo.SpecFlow
{
    [Binding]
    public class Person_AddSteps
    {
        [Given(@"I have a new person record with the following properties")]
        public void GivenIHaveANewPersonRecordWithTheFollowingProperties(Table table)
        {
            ScenarioContext.Current.Set<Person>(
                table.CreateInstance<Person>());
        }
        
        [When(@"I save the person")]
        public void WhenISaveThePerson()
        {
            var r = PersonRepository.Save(
                ScenarioContext.Current.Get<Person>());
            ScenarioContext.Current.Set<bool>(r, "SaveResult");
        }
        
        [Then(@"the person is saved successfully")]
        public void ThenThePersonIsSavedSuccessfully()
        {
            Assert.IsTrue(
                ScenarioContext.Current.Get<bool>("SaveResult"),
                "SaveResult");
        }
        
        [Then(@"I can retrieve the person by ID")]
        public void ThenICanRetrieveThePersonByID()
        {
            var expected = ScenarioContext.Current.Get<Person>();
            var actual = PersonRepository.Get(expected.Id);
            Assert.AreSame(expected, actual);
        }
    }
}
