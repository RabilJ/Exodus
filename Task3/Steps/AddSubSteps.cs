using Task3.Context;
using TechTalk.SpecFlow;

namespace Task3.Steps
{
    [Binding]
    public class AddSubSteps
    {
        private NumbersContext _numbersContext;
        private AddSub _addSub = new AddSub();

        public AddSubSteps(NumbersContext numbersContext)
        {
            _numbersContext = numbersContext;
        }
        
        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _numbersContext.Result = _addSub.Add(_numbersContext.FirstNumber, _numbersContext.SecondNumber);
        }

        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            _numbersContext.Result = _addSub.Subtract(_numbersContext.FirstNumber, _numbersContext.SecondNumber);
        }
    }
}