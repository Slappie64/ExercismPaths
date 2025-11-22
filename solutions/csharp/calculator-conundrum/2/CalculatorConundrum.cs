public static class SimpleCalculator
{
    
    
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        string _opMessage = $"{operand1} {operation} {operand2} = ";
        return operation switch
        {
            "+" => $"{_opMessage}{operand1+operand2}",
            "*" => $"{_opMessage}{operand1*operand2}",
            "/" => (operand1 == 0 || operand2 == 0) ? "Division by zero is not allowed." : $"{_opMessage}{operand1/operand2}",
            "" => throw new ArgumentException("empty"),
            null => throw new ArgumentNullException("null"),
            _ => throw new ArgumentOutOfRangeException("OOR")
        };
    }
}
