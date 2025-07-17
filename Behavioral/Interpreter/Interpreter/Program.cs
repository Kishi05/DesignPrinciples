using Interpreter.Expressions;
using Interpreter.Interface;

string input = "5 + 3 == 4 + 4";

var tokens = new Queue<string>(input.Split(' ', StringSplitOptions.RemoveEmptyEntries));
IExpression expression = ParseEquality(tokens);
Console.WriteLine($"Result: {expression.Interpret()}");

static IExpression ParseEquality(Queue<string> tokens)
{
    IExpression left = ParseArithmetic(tokens);

    while (tokens.Count > 0 && tokens.Peek() == "==")
    {
        tokens.Dequeue();
        IExpression right = ParseArithmetic(tokens);
        left = new CompareExpression(left, right);
    }

    return left;
}

static IExpression ParseArithmetic(Queue<string> tokens)
{
    IExpression left = ParseTerm(tokens);

    while (tokens.Count > 0 && (tokens.Peek() == "+" || tokens.Peek() == "-"))
    {
        string op = tokens.Dequeue();
        IExpression right = ParseTerm(tokens);

        left = op switch
        {
            "+" => new AddExpression(left, right),
            "-" => new SubtractExpression(left, right),
            _ => throw new InvalidOperationException("Unsupported operator.")
        };
    }

    return left;
}

static IExpression ParseTerm(Queue<string> tokens)
{
    string token = tokens.Dequeue();
    if (int.TryParse(token, out int number))
    {
        return new NumberExpression(number);
    }

    throw new InvalidOperationException($"Invalid token: {token}");
}