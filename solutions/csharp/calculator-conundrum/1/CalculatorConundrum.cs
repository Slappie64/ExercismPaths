public static class SimpleCalculator
{
    
    
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        string _opMessage = $"{operand1} {operation} {operand2} = ";
        try
        {
            return operation switch
            {
            "+" => $"{_opMessage}{operand1+operand2}",
            "*" => $"{_opMessage}{operand1*operand2}",
            "/" => (operand1 == 0 || operand2 == 0) ? throw new DivideByZeroException("zero") : $"{_opMessage}{operand1/operand2}",
            "" => throw new ArgumentException("empty"),
            null => throw new ArgumentNullException("null"),
            _ => throw new ArgumentOutOfRangeException("OOR")
            };
        }
        catch (ArgumentNullException e)
        {
            throw new ArgumentNullException("null");
        }
        catch (ArgumentOutOfRangeException)
        {
            throw new ArgumentOutOfRangeException("OOR");
        }
        catch (DivideByZeroException)
        {
            return "Division by zero is not allowed.";
        }
    }
}
