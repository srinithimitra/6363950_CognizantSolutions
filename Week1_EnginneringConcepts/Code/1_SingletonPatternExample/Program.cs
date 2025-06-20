using System;
using SingletonPatternExample;

class Program
{
    static void Main()
    {
        Logger logger1 = Logger.GetInstance();
        Logger logger2 = Logger.GetInstance();

        logger1.Log("First message");
        logger2.Log("Second message");

        
        Console.WriteLine(Object.ReferenceEquals(logger1, logger2)
            ? "Same instance confirmed."
            : "Different instances (not a Singleton).");
    }
}

