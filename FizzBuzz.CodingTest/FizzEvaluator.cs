using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.CodingTest;

/// <summary>
/// The Fizz Evaluator
/// </summary>
public class FizzEvaluator : IFizzBuzzEvaluator
{
    /// <inheritdoc/>
    public string OutputMessage { get; set; } = "Fizz";

    /// <summary>
    /// Evaluates if a number is divisible by 3.
    /// </summary>
    /// <param name="number"></param>
    /// <returns>returns a bool value.</returns>
    public bool CheckFizzBuzz(int number)
    {
        if (number % 3 == 0 && number % 5 != 0)
        {
            return true;
        }
        return false;
    }
}
