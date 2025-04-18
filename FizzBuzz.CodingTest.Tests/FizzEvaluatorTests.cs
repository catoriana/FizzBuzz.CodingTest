namespace FizzBuzz.CodingTest.Tests;

public class FizzEvaluatorTests
{
    private readonly IFizzBuzzEvaluator _evaluator;

    public FizzEvaluatorTests()
    {
        _evaluator = new FizzEvaluator();
    }

    [Theory]
    [InlineData(3, true)]
    [InlineData(5, false)]
    [InlineData(2, false)]
    [InlineData(15, false)]
    public void CheckFizzBuzz_ShouldReturnFizz_WhenDivisibleBy3Only(int number, bool expectedResult)
    {
        // Arrange
        var outputMessage = "Fizz";

        // Act
        bool result = _evaluator.CheckFizzBuzz(number);

        // Assert
        Assert.Equal(expectedResult, result);
        Assert.Equal(outputMessage, _evaluator.OutputMessage);
    }
}