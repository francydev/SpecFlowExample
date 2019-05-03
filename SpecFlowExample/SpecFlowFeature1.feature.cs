// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlowExample
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Items")]
    public partial class ItemsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SpecFlowFeature1.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Items", "\tImport files from external application", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Import a valid Items file")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void ImportAValidItemsFile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Import a valid Items file", null, new string[] {
                        "mytag"});
#line 5
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
#line 6
 testRunner.Given("the following specific Items file", @"ItemNo;CreatedOn;ModifiedOn;Disabled
10045112022051066;""4/20/2017 10:32 AM"";""4/21/2017 10:32 AM"";No
10045112022051064;""4/20/2017 10:32 AM"";""4/21/2017 10:32 AM"";No
10045112022051062;""4/20/2017 10:32 AM"";""4/21/2017 10:32 AM"";No
10045112022051070;""4/20/2017 10:32 AM"";""4/21/2017 10:32 AM"";No
10045112022051071;""4/20/2017 10:32 AM"";""4/21/2017 10:32 AM"";No
10045112022051072;""4/20/2017 10:32 AM"";""4/21/2017 10:32 AM"";No
10045112022051073;""4/20/2017 10:32 AM"";""4/21/2017 10:32 AM"";No
10045112022051074;""4/20/2017 10:32 AM"";""4/21/2017 10:32 AM"";No
10045112022051075;""4/20/2017 10:32 AM"";""4/21/2017 10:32 AM"";No", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
 testRunner.When("the service is started", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemNo",
                        "CreatedOn",
                        "ModifiedOn",
                        "Disabled"});
            table1.AddRow(new string[] {
                        "10045112022051066",
                        "\'2017-04-20 10:32:00.000\'",
                        "\'2017-04-21 10:32:00.000\'",
                        "0"});
            table1.AddRow(new string[] {
                        "10045112022051064",
                        "\'2017-04-20 10:32:00.000\'",
                        "\'2017-04-21 10:32:00.000\'",
                        "0"});
            table1.AddRow(new string[] {
                        "10045112022051062",
                        "\'2017-04-20 10:32:00.000\'",
                        "\'2017-04-21 10:32:00.000\'",
                        "0"});
            table1.AddRow(new string[] {
                        "10045112022051070",
                        "\'2017-04-20 10:32:00.000\'",
                        "\'2017-04-21 10:32:00.000\'",
                        "0"});
            table1.AddRow(new string[] {
                        "10045112022051071",
                        "\'2017-04-20 10:32:00.000\'",
                        "\'2017-04-21 10:32:00.000\'",
                        "0"});
            table1.AddRow(new string[] {
                        "10045112022051072",
                        "\'2017-04-20 10:32:00.000\'",
                        "\'2017-04-21 10:32:00.000\'",
                        "0"});
            table1.AddRow(new string[] {
                        "10045112022051073",
                        "\'2017-04-20 10:32:00.000\'",
                        "\'2017-04-21 10:32:00.000\'",
                        "0"});
            table1.AddRow(new string[] {
                        "10045112022051074",
                        "\'2017-04-20 10:32:00.000\'",
                        "\'2017-04-21 10:32:00.000\'",
                        "0"});
            table1.AddRow(new string[] {
                        "10045112022051075",
                        "\'2017-04-20 10:32:00.000\'",
                        "\'2017-04-21 10:32:00.000\'",
                        "0"});
#line 20
 testRunner.Then("the following records must be present in Items table", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
