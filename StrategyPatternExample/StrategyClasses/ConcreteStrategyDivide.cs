using System;
namespace StrategyPatternExample.StrategyClasses
{
    public class ConcreteStrategyDivide : IOperationStrategy
    {
        public ConcreteStrategyDivide()
        {
        }
        public int execute(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}
