using System;
namespace StrategyPatternExample.StrategyClasses
{
    public class Context
    {
        private IOperationStrategy _operation;

        public Context(IOperationStrategy operation)
        {
            _operation = operation;
        }

        public void SetOperation(IOperationStrategy operation)
        {
            _operation = operation;
        }

        public int ExecuteOperation(int a, int b)
        {
            return _operation.execute(a, b);
        }
    }
}
