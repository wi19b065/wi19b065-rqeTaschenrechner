using TechTalk.SpecFlow;
using wi19b065;
using Xunit;

namespace wi19b065

{

    public class SpecFlowFeature1Steps
    {
        private Calculator calc;
        private int result;

        [Given(@"a calculator object")]
        public void GivenACalculatorObject()
        {
            this.calc = new Calculator();
        }

        [When(@"adding (.) and (.)")]
        public void WhenAddingAnd(string p0, string p1)
        {
            result = calc.addiere(int.Parse(p0), int.Parse(p1));
        }

        [When(@"substracting (.) from  (.)")]
        public void WhenSubstractingFrom(string p0, string p1)
        {
            result = calc.subtrahiere(int.Parse(p1), int.Parse(p0));
        }

        [When(@"multypliing (.) with  (.)")]
        public void WhenMultypliingWith(string p0, string p1)
        {
            result = calc.multipliziere(int.Parse(p0), int.Parse(p1));
        }

        [When(@"divide (.) with  (.)")]
        public void WhenDivideWith(string p0, string p1)
        {
            result = calc.dividiere(int.Parse(p0), int.Parse(p1));
        }

        [Then(@"should return (.*)")]
        public void ThenShouldReturnSumm(string p0)
        {
            Assert.Equal(int.Parse(p0), result);
        }
    }
}