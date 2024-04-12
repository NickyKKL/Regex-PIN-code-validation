using System.Text.RegularExpressions;

namespace Regex_PIN_code_validation;

public class PinCodeValidator
{
    public static bool Validate(string code)
    {
        string pattern = @"^(?=.*q)(\S{6}|\S{10})$";
        return Regex.IsMatch(code, pattern);
    }
}
