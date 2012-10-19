using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace samples.SpecFlowDemo.SpecFlow
{
    [Binding]
    public class Person_UpdateSteps : Steps
    {
        [Given(@"I have an existing person record")]
        public void GivenIHaveAnExistingPersonRecord()
        {
            var header = new[] { "Field", "Value" };
            var t = new Table(header);
            t.AddRow("id", "100");
            t.AddRow("name", "Fred");
            t.AddRow("date of birth", "12/15/1990");

            Given("I have a new person record with the following properties", t);
            When("I save the person");
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
