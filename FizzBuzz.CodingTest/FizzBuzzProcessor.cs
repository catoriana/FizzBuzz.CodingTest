using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.CodingTest;

/// <summary>
/// The Fizz Buzz Proccessor - Entry Point for initial Fizz Buzz Processing
/// </summary>
/// <seealso cref="IFizzBuzzProcessor" />
public class FizzBuzzProcessor : IFizzBuzzProcessor
{
    /// <summary>
    /// Gets all classes that implement IFizzBuzzEvaluator through reflection.
    /// </summary>
    /// <returns>returns a list of IFizzBuzzEvaluators.</returns>
    public List<IFizzBuzzEvaluator> GetEvaluators()
    {
        Type type = typeof(IFizzBuzzEvaluator);
        var instances = Assembly.GetExecutingAssembly().GetTypes();
        var evaluators = new List<IFizzBuzzEvaluator>();
        foreach (var instance in instances)
        {
            if (type.IsAssignableFrom(instance) && !instance.IsInterface)
            {
                var evaluatorInstance = Activator.CreateInstance(instance) as IFizzBuzzEvaluator;
                if (evaluatorInstance != null)
                {
                    evaluators.Add(evaluatorInstance);
                }
            }
        }
        return evaluators;
    }

    /// <summary>
    /// Processes a range of numbers from 1 to 100 to output.
    /// </summary>
    /// <param name="startRange">int start range of number.</param>
    /// <param name="endRange">int end ragnge of number</param>
    /// <returns>returns a string, with a list of values.</returns>
    public string Process(int startRange, int endRange)
    {
        var output = new List<string>();
        var evaluators = GetEvaluators();
        while (startRange <= endRange)
        {

            foreach (var evaluator in evaluators)
            {
                if (evaluator.CheckFizzBuzz(startRange))
                {
                    output.Add(evaluator.OutputMessage);
                }
            }
            startRange++;
        }
        return string.Join(",", output);
    }
}
