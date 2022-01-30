using FluentAssertions;
using Task3.Context;
using TechTalk.SpecFlow;

namespace Task3.Steps
{
    [Binding]
    public class CommonSteps
    {
        private NumbersContext _numbersContext;
        
        public CommonSteps(NumbersContext numbersContext)
        {
            _numbersContext = numbersContext;
        }
        
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            _numbersContext.FirstNumber = p0;
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            _numbersContext.SecondNumber = p0;
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            _numbersContext.Result.Should().Be(p0);
        }
    }
}