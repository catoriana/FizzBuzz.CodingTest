using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.CodingTest.Tests;

public class BuzzEvaluatorTests
{
    [Theory]
    [InlineData(5, true)]
    [InlineData(3, false)]
    [InlineData(2, false)]
    [InlineData(15, false)]
    public void CheckFizzBuzz_ShouldReturnBuzz_WhenDivisibleBy5Only(int number, bool expectedResult)
    {
        Assert.Fail();
    }
}
