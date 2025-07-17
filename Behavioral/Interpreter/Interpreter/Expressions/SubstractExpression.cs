using Interpreter.Interface;

namespace Interpreter.Expressions
{
    internal class SubtractExpression : IExpression
    {
        private readonly IExpression _left;
        private readonly IExpression _right;

        public SubtractExpression(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public dynamic Interpret() => _left.Interpret() - _right.Interpret();
    }
}
