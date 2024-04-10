using System.Text.RegularExpressions;

namespace Regex_PIN_code_validation;

public class PinCodeValidator
{
    public static void Validator(string code)
    {
        string pattern = @"^(?=.*q)(\S{6}|\S{10})$";
        Console.WriteLine($"{code} --> {Regex.IsMatch(code, pattern)}");
    }
}
