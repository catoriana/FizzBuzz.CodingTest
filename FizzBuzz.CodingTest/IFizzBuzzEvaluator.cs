using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.CodingTest;

/// <summary>
/// Defines a contract for evaluator implementations.
/// </summary>
public interface IFizzBuzzEvaluator
{
    /// <summary>
    /// Gets or sets the output message.
    /// </summary>
    string OutputMessage { get; set; }

    /// <summary>
    /// Checks if the number is a FizzBuzz number.
    /// </summary>
    /// <param name="number"></param>
    /// <returns>bool if the number is a FizzBuzz number.</returns>
    bool CheckFizzBuzz(int number);
}
