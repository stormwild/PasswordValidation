using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PasswordValidator
{
  public class PasswordValidatorLocalFunction
  {
    private List<string> _errors = new List<string>();
    public List<string> Errors { get { return _errors; } }

    public bool IsValid(string password)
    {
      bool HasUppercase()
      {
        return Regex.Match(password, @"[A-Z]+").Success;
      }

      bool HasLowercase()
      {
        return Regex.Match(password, @"[a-z]+").Success;
      }

      bool HasDigit()
      {
        return Regex.Match(password, @"[0-9]+").Success;
      }

      bool HasMinLengthTwelve()
      {
        return password.Length >= 12;
      }

      if (!HasUppercase())
      {
        _errors.Add("Password must have at least one uppercase letter");
      }

      if (!HasLowercase())
      {
        _errors.Add("Password must have at least one lowercase letter");
      }

      if (!HasDigit())
      {
        _errors.Add("Password must have at least one digit");
      }

      if (!HasMinLengthTwelve())
      {
        _errors.Add("Password must be 12 characters or more");
      }

      return HasUppercase() && HasLowercase() && HasDigit() && HasMinLengthTwelve();
    }
  }
}