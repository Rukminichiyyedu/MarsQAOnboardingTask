namespace MarsQA_1.Feature
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
[System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
[NUnit.Framework.TestFixtureAttribute()]
[NUnit.Framework.DescriptionAttribute("Profile Description")]
public partial class ProfileDescriptionFeature
{

    private TechTalk.SpecFlow.ITestRunner testRunner;

    private string[] _featureTags = ((string[])(null));

#line 1 "Description.feature"
#line hidden

    [NUnit.Framework.OneTimeSetUpAttribute()]
    public virtual void FeatureSetup()
    {
        testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
        TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Profile Description", @"As a Seller
I want the feature to add my Description to the Profile
The people seeking for Description can look into my details.
Acceptance Criteria
Seller is able to add the Description.
Prerequisite Seller is registered and logged in to website with valid credientials 
and on Profile Tab", "Adding seller details", ((string[])(null)));
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
    public virtual void TestTearDown()
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
     public   System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
        [NUnit.Framework.TestAttribute()]
    [NUnit.Framework.DescriptionAttribute("Seller adding description")]
    [NUnit.Framework.CategoryAttribute("mytag")]

    public virtual void SellerAddingDescription()
    {
        string[] tagsOfScenario = new string[] {
                    "mytag"};
        TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Seller adding description", null, new string[] {
                        "mytag"},argumentsOfScenario);
#line 11
        this.ScenarioInitialize(scenarioInfo);
#line hidden
        bool isScenarioIgnored = default(bool);
        bool isFeatureIgnored = default(bool);
        if ((tagsOfScenario != null))
        {
            isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
        }
        if ((this._featureTags != null))
        {
            isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
        }
        if ((isScenarioIgnored || isFeatureIgnored))
        {
            testRunner.SkipScenario();
        }
        else
        {
            this.ScenarioStart();
#line 12
            testRunner.Given("I am on Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 13
            testRunner.And("I click on pencil button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
            testRunner.And("I enter description", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
            testRunner.When("I click Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
            testRunner.Then("the description is added to Profile successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        this.ScenarioCleanup();
    }

    [NUnit.Framework.TestAttribute()]
    [NUnit.Framework.DescriptionAttribute("Seller adding description more than 600 characters")]
    [NUnit.Framework.CategoryAttribute("mytag")]
    public virtual void SellerAddingDescriptionMoreThan600Characters()
    {
        string[] tagsOfScenario = new string[] {
                    "mytag"};
        TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Seller adding description more than 600 characters", null, new string[] {
                        "mytag"},argumentsOfScenario);
#line 19
        this.ScenarioInitialize(scenarioInfo);
#line hidden
        bool isScenarioIgnored = default(bool);
        bool isFeatureIgnored = default(bool);
        if ((tagsOfScenario != null))
        {
            isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
        }
        if ((this._featureTags != null))
        {
            isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
        }
        if ((isScenarioIgnored || isFeatureIgnored))
        {
            testRunner.SkipScenario();
        }
        else
        {
            this.ScenarioStart();
#line 20
            testRunner.Given("I am on Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 21
            testRunner.And("I click on pencil button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
            testRunner.And("I type description more than 600 characters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
            testRunner.And("I am not able to enter more than 600 characters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
            testRunner.When("I click Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
            testRunner.Then("the description is added to Profile successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        this.ScenarioCleanup();
    }

    [NUnit.Framework.TestAttribute()]
    [NUnit.Framework.DescriptionAttribute("Seller adding description where first character is special character")]
    [NUnit.Framework.CategoryAttribute("mytag")]
    public virtual void SellerAddingDescriptionWhereFirstCharacterIsSpecialCharacter()
    {
        string[] tagsOfScenario = new string[] {
                    "mytag"};
        TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Seller adding description where first character is special character", null, new string[] {
                        "mytag"},argumentsOfScenario);
#line 28
        this.ScenarioInitialize(scenarioInfo);
#line hidden
        bool isScenarioIgnored = default(bool);
        bool isFeatureIgnored = default(bool);
        if ((tagsOfScenario != null))
        {
            isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
        }
        if ((this._featureTags != null))
        {
            isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
        }
        if ((isScenarioIgnored || isFeatureIgnored))
        {
            testRunner.SkipScenario();
        }
        else
        {
            this.ScenarioStart();
#line 29
            testRunner.Given("I am on Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 30
            testRunner.And("I click on pencil button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
            testRunner.And("I type description starting with special characters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
            testRunner.When("I click Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
            testRunner.Then("Error message thrown \'First character can only be digit or letters.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        this.ScenarioCleanup();
    }

    [NUnit.Framework.TestAttribute()]
    [NUnit.Framework.DescriptionAttribute("Seller saving blank description")]
    [NUnit.Framework.CategoryAttribute("mytag")]
    public virtual void SellerSavingBlankDescription()
    {
        string[] tagsOfScenario = new string[] {
                    "mytag"};
        TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Seller saving blank description", null, new string[] {
                        "mytag"},argumentsOfScenario);
#line 36
        this.ScenarioInitialize(scenarioInfo);
#line hidden
        bool isScenarioIgnored = default(bool);
        bool isFeatureIgnored = default(bool);
        if ((tagsOfScenario != null))
        {
            isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
        }
        if ((this._featureTags != null))
        {
            isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
        }
        if ((isScenarioIgnored || isFeatureIgnored))
        {
            testRunner.SkipScenario();
        }
        else
        {
            this.ScenarioStart();
#line 37
            testRunner.Given("I am on Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 38
            testRunner.And("I click on pencil button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
            testRunner.And("No description typed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
            testRunner.When("I click Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 41
            testRunner.Then("Error thrown \'Please, a description is required\'.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        this.ScenarioCleanup();
    }

    [NUnit.Framework.TestAttribute()]
    [NUnit.Framework.DescriptionAttribute("Seller updating description")]
    [NUnit.Framework.CategoryAttribute("mytag")]
    public virtual void SellerUpdatingDescription()
    {
        string[] tagsOfScenario = new string[] {
                    "mytag"};
        TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Seller updating description", null, new string[] {
                        "mytag"},argumentsOfScenario);
#line 44
        this.ScenarioInitialize(scenarioInfo);
#line hidden
        bool isScenarioIgnored = default(bool);
        bool isFeatureIgnored = default(bool);
        if ((tagsOfScenario != null))
        {
            isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
        }
        if ((this._featureTags != null))
        {
            isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
        }
        if ((isScenarioIgnored || isFeatureIgnored))
        {
            testRunner.SkipScenario();
        }
        else
        {
            this.ScenarioStart();
#line 45
            testRunner.Given("I am on Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 46
            testRunner.And("I click on pencil button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
            testRunner.And("I add/delete information in description", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 48
            testRunner.When("I click save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 49
            testRunner.Then("Description is updated successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        this.ScenarioCleanup();
    }

    [NUnit.Framework.TestAttribute()]
    [NUnit.Framework.DescriptionAttribute("Seller updating description more than 600 characters")]
    [NUnit.Framework.CategoryAttribute("mytag")]
    public virtual void SellerUpdatingDescriptionMoreThan600Characters()
    {
        string[] tagsOfScenario = new string[] {
                    "mytag"};
        TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Seller updating description more than 600 characters", null, new string[] {
                        "mytag"},argumentsOfScenario);
#line 52
        this.ScenarioInitialize(scenarioInfo);
#line hidden
        bool isScenarioIgnored = default(bool);
        bool isFeatureIgnored = default(bool);
        if ((tagsOfScenario != null))
        {
            isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
        }
        if ((this._featureTags != null))
        {
            isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
        }
        if ((isScenarioIgnored || isFeatureIgnored))
        {
            testRunner.SkipScenario();
        }
        else
        {
            this.ScenarioStart();
#line 53
            testRunner.Given("I am on Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 54
            testRunner.And("I click on pencil button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 55
            testRunner.And("I update description more than 600 characters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
            testRunner.And("I am not able to enter more than 600 characters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
            testRunner.When("I click Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 58
            testRunner.Then("the description is added to Profile successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        this.ScenarioCleanup();
    }

    [NUnit.Framework.TestAttribute()]
    [NUnit.Framework.DescriptionAttribute("Seller updating description where first character is special character")]
    [NUnit.Framework.CategoryAttribute("mytag")]
    public virtual void SellerUpdatingDescriptionWhereFirstCharacterIsSpecialCharacter()
    {
        string[] tagsOfScenario = new string[] {
                    "mytag"};
        TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Seller updating description where first character is special character", null, new string[] {
                        "mytag"},argumentsOfScenario);
#line 61
        this.ScenarioInitialize(scenarioInfo);
#line hidden
        bool isScenarioIgnored = default(bool);
        bool isFeatureIgnored = default(bool);
        if ((tagsOfScenario != null))
        {
            isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
        }
        if ((this._featureTags != null))
        {
            isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
        }
        if ((isScenarioIgnored || isFeatureIgnored))
        {
            testRunner.SkipScenario();
        }
        else
        {
            this.ScenarioStart();
#line 62
            testRunner.Given("Iam on Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 63
            testRunner.And("I click on pencil button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 64
            testRunner.And("I update description initialising with special characters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 65
            testRunner.When("I click Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 66
            testRunner.Then("Error message thrown \'First character can only be digit or letters.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        this.ScenarioCleanup();
    }

    [NUnit.Framework.TestAttribute()]
    [NUnit.Framework.DescriptionAttribute("Seller updating blank description")]
    [NUnit.Framework.CategoryAttribute("mytag")]
    public virtual void SellerUpdatingBlankDescription()
    {
        string[] tagsOfScenario = new string[] {
                    "mytag"};
        TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Seller updating blank description", null, new string[] {
                        "mytag"},argumentsOfScenario);
#line 69
        this.ScenarioInitialize(scenarioInfo);
#line hidden
        bool isScenarioIgnored = default(bool);
        bool isFeatureIgnored = default(bool);
        if ((tagsOfScenario != null))
        {
            isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
        }
        if ((this._featureTags != null))
        {
            isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
        }
        if ((isScenarioIgnored || isFeatureIgnored))
        {
            testRunner.SkipScenario();
        }
        else
        {
            this.ScenarioStart();
#line 70
            testRunner.Given("I am on Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 71
            testRunner.And("I click on pencil button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
            testRunner.And("All description is erased", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
            testRunner.When("I click Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 74
            testRunner.Then("Error thrown \'Please, a description is required\'.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        this.ScenarioCleanup();
    }
}
}
