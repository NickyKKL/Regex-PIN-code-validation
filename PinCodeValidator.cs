using System.Text.RegularExpressions;

namespace Regex_PIN_code_validation;

public class PinCodeValidator
{
    public static bool Validator(string code)
    {
        string pattern = @"^(?=.*q)(\S{6}|\S{10})$";

        if (Regex.IsMatch(code, pattern))
        {
            Console.WriteLine($"{code} --> {true}");
            return true;
        }

        Console.WriteLine($"{code} --> {false}");
        return false;
    }
}
