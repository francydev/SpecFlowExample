using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using System.Linq;

namespace SpecFlowExample
{
    [Binding]
    public class ItemsSteps
    {
        List<string> itemList = new List<string>();

        [Given(@"the following specific Items file")]
        public void GivenTheFollowingSpecificItemsFile(string multilineText)
        {
            File.WriteAllText(
                Path.Combine(@"c:\temp", $"TEST_items.csv"),
                multilineText);
        }
        
        [When(@"the service is started")]
        public void WhenTheServiceIsStarted()
        {
            MyService service = new MyService();
            service.Start();
        }
        
        [Then(@"the following records must be present in Items table")]
        public void ThenTheFollowingRecordsMustBePresentInItemsTable(Table table)
        {
            foreach(var item in table.Rows)
            {
                Assert.IsTrue(FakeDatabase.ItemTable.Any(i => i.ItemNo == item[0]));
            }
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            File.Delete(@"c:\temp\TEST_items.csv");
        }
    }
}
