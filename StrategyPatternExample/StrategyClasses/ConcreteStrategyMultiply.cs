using System;
namespace StrategyPatternExample.StrategyClasses
{
    public class ConcreteStrategyMultiply : IOperationStrategy
    {
        public ConcreteStrategyMultiply()
        {
        }

        public int execute(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}
