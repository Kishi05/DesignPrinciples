using Interpreter.Interface;

namespace Interpreter.Expressions
{
    internal class AddExpression : IExpression
    {
        private readonly IExpression _left;
        private readonly IExpression _right;

        public AddExpression(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public dynamic Interpret() => _left.Interpret() + _right.Interpret();
    }
}
