using Interpreter.Interface;

namespace Interpreter.Expressions
{
    internal class CompareExpression : IExpression
    {
        private readonly IExpression _left;
        private readonly IExpression _right;

        public CompareExpression(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public dynamic Interpret() => _left.Interpret().Equals(_right.Interpret());
    }
}
