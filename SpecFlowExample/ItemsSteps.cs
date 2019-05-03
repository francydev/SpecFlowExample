using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace SpecFlowExample
{
    [Binding]
    public class ItemsSteps
    {
        [Given(@"the following specific Items file")]
        public void GivenTheFollowingSpecificItemsFile(string multilineText)
        {
            File.WriteAllText(
                Path.Combine("c:\temp", $"TEST_items.csv"),
                multilineText);
        }
        
        [When(@"the service is started")]
        public void WhenTheServiceIsStarted()
        {
            var test = true;
        }
        
        [Then(@"the following records must be present in Items table")]
        public void ThenTheFollowingRecordsMustBePresentInItemsTable(Table table)
        {
            Assert.IsTrue(true);   
        }
    }
}
