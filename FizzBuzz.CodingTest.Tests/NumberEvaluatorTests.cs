using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.CodingTest.Tests;

public class NumberEvaluatorTests
{
    private readonly IFizzBuzzEvaluator _evaluator;

    public NumberEvaluatorTests()
    {
        _evaluator = new NumberEvaluator();
    }

    [Theory]
    [InlineData(2, true)]
    [InlineData(3, false)]
    [InlineData(5, false)]
    [InlineData(15, false)]
    public void CheckFizzBuzz_ShouldReturnNumber_WhenNotDivisibleBy3And5(int number, bool expectedResult)
    {
        //Arrange
        var outputMessage = number.ToString();
        // Act
        bool result = _evaluator.CheckFizzBuzz(number);

        // Assert
        Assert.Equal(expectedResult, result);
        if (result)
        {
            Assert.Equal(outputMessage, _evaluator.OutputMessage);
        }
    }
}
