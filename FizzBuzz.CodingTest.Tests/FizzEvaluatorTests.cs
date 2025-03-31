namespace FizzBuzz.CodingTest.Tests;

public class FizzEvaluatorTests
{
    private readonly FizzEvaluator _evaluator;

    public FizzEvaluatorTests()
    {
        _evaluator = new FizzEvaluator();
    }

    [Theory]
    [InlineData(3, true)]
    public void CheckFizzBuzz_ShouldReturnFizz_WhenDivisibleBy3Only(int number, bool expectedResult)
    {
       Assert.Fail();
    }
}