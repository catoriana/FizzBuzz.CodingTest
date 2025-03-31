using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.CodingTest;

public class FizzEvaluator : IFizzBuzzEvaluator
{
    public string OutputMessage => "Fizz";

    public bool CheckFizzBuzz(int number)
    {
        if (number % 3 == 0 && number % 5 != 0)
        {
            return true;
        }
        return false;
    }
}
