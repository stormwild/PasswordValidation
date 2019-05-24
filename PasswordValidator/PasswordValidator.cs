using System;
using System.Text.RegularExpressions;

namespace PasswordValidator
{
  public class PasswordValidator
  {
    public bool HasUppercase(string password)
    {
      return Regex.Match(password, @"[A-Z]+").Success;
    }

    public bool HasLowercase(string password)
    {
      return Regex.Match(password, @"[a-z]+").Success;
    }

    public bool HasDigit(string password)
    {
      return Regex.Match(password, @"[0-9]+").Success;
    }

    public bool HasMinLengthTwelve(string password)
    {
      return password.Length >= 12;
    }

    public bool IsValid(string password)
    {
      return HasUppercase(password) && HasLowercase(password) && HasDigit(password) && HasMinLengthTwelve(password);
    }
  }
}
