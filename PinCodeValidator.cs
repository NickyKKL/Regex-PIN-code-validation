using System.Text.RegularExpressions;

namespace Regex_PIN_code_validation;

public class PinCodeValidator
{
    public static bool Validator(string code)
    {
        string pattern = @"^(?=.*q)(\S{6}|\S{10})$";
        var regex = Regex.IsMatch(code, pattern);
        Console.WriteLine($"{code} --> {regex}");

        return regex;
    }
}
