# FizzBuzz Coding Test
* Please review commits via branch history to see the timeline and implementation of the solution
* All Unit Tests passing
* Implemented with SOLID design patterns
*The entry point for processing is the FizzBuzzProcessor, which takes a range of numbers and evaluates each number using dynamically instantiated classes that implement IFizzBuzzEvaluator
## Rules
* Numbers divisible only by 3 output Fizz.
* Numbers divisible only by 5 output Buzz.
* Numbers divisible by both 3 and 5 output FizzBuzz.
* All other numbers output the number itself.
## FizzBuzzProcessor 
* Uses reflection to instantiate evaluator classes dynamically.
* Iterates through numbers and applies evaluators.
## IFizzBuzzEvaluator 
* Defines a contract for evaluator implementations.
## Concrete Implementations of IFizzBuzzEvaluator
* FizzEvaluator: Returns "Fizz" for numbers divisible only by 3
* BuzzEvaluator: Returns "Buzz" for numbers divisible only by 5
* FizzBuzzEvaluator: Returns "FizzBuzz" for numbers divisible by both 3 and 5.
* NumberEvaluator: Returns the number as a string if no conditions match.

