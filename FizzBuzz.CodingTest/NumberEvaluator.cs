using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.CodingTest;

/// <summary>
/// The Number Evaluator
/// </summary>
public class NumberEvaluator : IFizzBuzzEvaluator
{
    ///<inheritdoc/>
    public string OutputMessage { get; set; } = string.Empty;

    /// <summary>
    /// Evaluates if a number is not divisible by 3 or 5.
    /// </summary>
    /// <param name="number"></param>
    /// <returns>bool value.</returns>
    public bool CheckFizzBuzz(int number)
    {
        if (number % 3 != 0 && number % 5 != 0)
        {
            OutputMessage = number.ToString();
            return true;
        }
        return false;
    }
}
