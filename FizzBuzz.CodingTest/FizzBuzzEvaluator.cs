using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.CodingTest;

/// <summary>
/// The Fizz Buzz Evaluator
/// </summary>
public class FizzBuzzEvaluator : IFizzBuzzEvaluator
{
    /// <inheritdoc/>
    public string OutputMessage { get; set; } = "FizzBuzz";

    /// <summary>
    /// Evaluates if a number is divisible by 3 and 5.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public bool CheckFizzBuzz(int number)
    {
        if (number % 3 == 0 && number % 5 == 0)
        {
            return true;
        }
        return false;
    }
}
