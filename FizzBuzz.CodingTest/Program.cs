namespace FizzBuzz.CodingTest;
public class Program
{
    static void Main(string[] args)
    {
        var _processor = new FizzBuzzProcessor();
        Console.WriteLine(_processor.Process(1, 100));
    }
}
