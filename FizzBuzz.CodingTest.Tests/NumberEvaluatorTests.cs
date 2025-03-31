using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.CodingTest.Tests;

public class NumberEvaluatorTests
{
    [Theory]
    [InlineData(2, true)]
    [InlineData(3, false)]
    [InlineData(5, false)]
    [InlineData(15, false)]
    public void CheckFizzBuzz_ShouldReturnNumber_WhenNotDivisibleBy3And5(int number, bool expectedResult)
    {
        Assert.Fail();
    }
}
