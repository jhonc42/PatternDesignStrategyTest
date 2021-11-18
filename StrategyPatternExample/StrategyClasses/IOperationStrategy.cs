using System;
namespace StrategyPatternExample.StrategyClasses
{
    public interface IOperationStrategy
    {
        int execute(int number1, int number2);
    }
}
