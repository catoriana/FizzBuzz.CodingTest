﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.CodingTest;

public interface IFizzBuzzEvaluator
{
    string OutputMessage { get; }

    bool CheckFizzBuzz(int number);
}
