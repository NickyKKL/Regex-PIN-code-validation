using Regex_PIN_code_validation;

Console.WriteLine($"{"12345q"} --> {PinCodeValidator.Validate("12345q")}");
Console.WriteLine($"{"12345"} --> {PinCodeValidator.Validate("12345")}");
Console.WriteLine($"{"045654q345"} --> {PinCodeValidator.Validate("045654q345")}");
