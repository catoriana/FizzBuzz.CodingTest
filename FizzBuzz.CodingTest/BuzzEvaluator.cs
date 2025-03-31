using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.CodingTest;

public class BuzzEvaluator : IFizzBuzzEvaluator
{
    public string OutputMessage { get; set; } = "Buzz";

    public bool CheckFizzBuzz(int number)
    {
        if (number % 5 == 0 && number % 3 != 0)
        {
            return true;
        }
        return false;
    }
}
