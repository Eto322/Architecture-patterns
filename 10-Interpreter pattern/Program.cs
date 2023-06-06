using System;
namespace InterpreterPatternExample{
// Abstract expression
public abstract class Expression
{
    public abstract int Interpret();
}

// Terminal expression
public class NumberExpression : Expression
{
    private int _number;

    public NumberExpression(int number)
    {
        _number = number;
    }

    public override int Interpret()
    {
        return _number;
    }
}

// Non-terminal expression
public class AdditionExpression : Expression
{
    private Expression _leftExpression;
    private Expression _rightExpression;

    public AdditionExpression(Expression leftExpression, Expression rightExpression)
    {
        _leftExpression = leftExpression;
        _rightExpression = rightExpression;
    }

    public override int Interpret()
    {
        return _leftExpression.Interpret() + _rightExpression.Interpret();
    }
}

// Non-terminal expression
public class SubtractionExpression : Expression
{
    private Expression _leftExpression;
    private Expression _rightExpression;

    public SubtractionExpression(Expression leftExpression, Expression rightExpression)
    {
        _leftExpression = leftExpression;
        _rightExpression = rightExpression;
    }

    public override int Interpret()
    {
        return _leftExpression.Interpret() - _rightExpression.Interpret();
    }
}

// Client
public class Client
{
    public static void Main()
    {
        // Create the expression tree: 5 + (2 - 3)
        Expression expression = new AdditionExpression(
            new NumberExpression(5),
            new SubtractionExpression(
                new NumberExpression(2),
                new NumberExpression(3)
            )
        );

        // Interpret the expression
        int result = expression.Interpret();
        Console.WriteLine("Result: " + result); // Output: Result: 4
    }
}

}