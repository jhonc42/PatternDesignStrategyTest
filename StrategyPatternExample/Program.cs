using System;
using StrategyPatternExample.StrategyClasses;

namespace StrategyPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var contextObject = new Context(new ConcreteStrategyAdd());
            Console.WriteLine("What kind of operation would you choose? (add,subtract,multiply,divide)");

            var operationSelected = Console.ReadLine();

            switch (operationSelected)
            {
                case "add":
                    contextObject.SetOperation(new ConcreteStrategyAdd());
                    break;
                case "subtract":
                    contextObject.SetOperation(new ConcreteStrategySubtract());
                    break;
                case "multiply":
                    contextObject.SetOperation(new ConcreteStrategyMultiply());
                    break;
                case "divide":
                    contextObject.SetOperation(new ConcreteStrategyDivide());
                    break;
                default:
                    Console.WriteLine("We don't have that operation yet!");
                    return;
            }

            Console.WriteLine("Please, Type the first number to execute the operation:");
            var firstNumber = Console.ReadLine();
            Console.WriteLine("Please, Type the second number to execute the operation:");
            var secondNumber = Console.ReadLine();

            var result = contextObject.ExecuteOperation(Convert.ToInt32(firstNumber), Convert.ToInt32(secondNumber));
            Console.WriteLine($"Result Operation is: {result}");
            Console.ReadLine();
        }
    }
}
