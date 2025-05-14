

namespace LibDocsDemo.Math;

/// <summary>
/// Provides basic arithmetic operations.
/// </summary>
public static class Calculator
{
    /// <summary>
    /// Adds two numbers.
    /// </summary>
    public static double Add(double a, double b) => a + b;

    /// <summary>
    /// Subtracts the second number from the first.
    /// </summary>
    public static double Subtract(double a, double b) => a - b;

    /// <summary>
    /// Multiplies two numbers.
    /// </summary>
    public static double Multiply(double a, double b) => a * b;

    /// <summary>
    /// Divides the first number by the second.
    /// </summary>
    /// <exception cref="DivideByZeroException">Thrown when the divisor is zero.</exception>
    public static double Divide(double a, double b) =>
        b != 0 ? a / b : throw new DivideByZeroException("Cannot divide by zero.");
}
