using TechTalk.SpecFlow;
using FluentAssertions;

namespace SpecFlowCalculator_Subtraction.specs.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private readonly Class1 _class1 = new Class1();
        private int _result;


        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _class1.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _class1.SecondNumber = number;
        }

        [When("the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            _result = _class1.Subtract();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }
    }
}
