using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.CodingTest;

public interface IFizzBuzzProcessor
{
    /// <summary>
    /// Processes a range of numbers from 1 to 100 to output .
    /// </summary>
    /// <returns>List of IFizzBuzzEvaluator.</returns>
    string Process(int startRange, int endRange);

    /// <summary>
    /// Gets all classes that implement IFizzBuzzEvaluator.
    /// </summary>
    /// <returns>List of IFizzBuzzEvaluator.</returns>
    List<IFizzBuzzEvaluator> GetEvaluators();
}
