using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.CodingTest;

public class NumberEvaluator : IFizzBuzzEvaluator
{
    public string OutputMessage { get; set; } = string.Empty;

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
