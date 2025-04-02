using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.CodingTest;

/// <summary>
/// The Buzz Evaluator.
/// </summary>
public class BuzzEvaluator : IFizzBuzzEvaluator
{
    /// <inheritdoc/>
    public string OutputMessage { get; set; } = "Buzz";

    /// <summary>
    /// Evaluates if a number is divisible by 5.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public bool CheckFizzBuzz(int number)
    {
        if (number % 5 == 0 && number % 3 != 0)
        {
            return true;
        }
        return false;
    }
}
