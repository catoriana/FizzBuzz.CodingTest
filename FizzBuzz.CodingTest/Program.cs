using Microsoft.Extensions.DependencyInjection;

namespace FizzBuzz.CodingTest;
public class Program
{
    static void Main(string[] args)
    {
        //No need to inject the evaulators here, the processor will take care of that via reflection
        //but normally you would inject the evaluators here
        var serviceProvider = new ServiceCollection()
        .AddSingleton<IFizzBuzzProcessor, FizzBuzzProcessor>()
        .BuildServiceProvider();


        // Get an instance of the service from the DI container
        var _processor = serviceProvider.GetRequiredService<IFizzBuzzProcessor>();

        Console.WriteLine(_processor.Process(1, 100));
    }
}
