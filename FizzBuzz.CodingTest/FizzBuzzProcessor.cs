using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.CodingTest;

public class FizzBuzzProcessor : IFizzBuzzProcessor
{
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
