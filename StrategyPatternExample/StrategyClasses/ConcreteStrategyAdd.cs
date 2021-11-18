using System;
namespace StrategyPatternExample.StrategyClasses
{
    public class ConcreteStrategyAdd : IOperationStrategy
    {
        public ConcreteStrategyAdd()
        {
        }

        public int execute(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
