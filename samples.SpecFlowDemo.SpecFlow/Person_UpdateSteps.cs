using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace samples.SpecFlowDemo.SpecFlow
{
    [Binding]
    public class Person_UpdateSteps
    {
        [Given(@"I have an existing person record")]
        public void GivenIHaveAnExistingPersonRecord()
        {
            ScenarioContext.Current.Set<Person>(
                PersonRepository.Get(1));
        }
        
        [When(@"I change the person name to ""(.*)""")]
        public void WhenIChangeThePersonNameTo(string p0)
        {
            var p = ScenarioContext.Current.Get<Person>();
            p.Name = p0;
        }
                
        [Then(@"the person name was saved as ""(.*)""")]
        public void ThenThePersonNameWasSavedAs(string p0)
        {
            var p = ScenarioContext.Current.Get<Person>();
            Assert.AreEqual(p0, p.Name);
        }
    }
}
