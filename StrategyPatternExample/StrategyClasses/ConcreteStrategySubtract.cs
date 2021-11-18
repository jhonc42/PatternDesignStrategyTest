using System;
namespace StrategyPatternExample.StrategyClasses
{
    public class ConcreteStrategySubtract : IOperationStrategy
    {
        public ConcreteStrategySubtract()
        {
        }
        public int execute(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}
