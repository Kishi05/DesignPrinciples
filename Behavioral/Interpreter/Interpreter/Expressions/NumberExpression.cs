using Interpreter.Interface;

namespace Interpreter.Expressions
{
    internal class NumberExpression : IExpression
    {
        private readonly int _number;

        public NumberExpression(int number)
        {
            _number = number;
        }

        public dynamic Interpret() => _number;
    }
}
