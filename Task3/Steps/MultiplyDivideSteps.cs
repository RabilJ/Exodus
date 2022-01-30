using Task3.Context;
using TechTalk.SpecFlow;

namespace Task3.Steps
{
    [Binding]
    public class MultiplyDivideSteps
    {
        private NumbersContext _numbersContext;
        private DivideMultiply _divideMultiply = new DivideMultiply();

        public MultiplyDivideSteps(NumbersContext numbersContext)
        {
            _numbersContext = numbersContext;
        }
        
        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _numbersContext.Result = _divideMultiply.Multiply(_numbersContext.FirstNumber, _numbersContext.SecondNumber);
        }

        [When(@"the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            _numbersContext.Result = _divideMultiply.Divide(_numbersContext.FirstNumber, _numbersContext.SecondNumber);
        }
    }
}