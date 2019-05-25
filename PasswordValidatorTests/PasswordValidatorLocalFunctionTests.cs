using System.Linq;
using PasswordValidator;
using Xunit;

namespace PasswordValidatorTests
{
  public class PasswordValidatorLocalFunctionTests
  {
    private PasswordValidatorLocalFunction validator = new PasswordValidatorLocalFunction();

    public void ReturnsErrorsWhenIsValidIsFalse()
    {
      var valid = validator.IsValid("     ");
      Assert.True(validator.Errors.Any());
      Assert.True(validator.Errors.Count() == 4);
    }

    [Fact]
    public void ReturnsTrueWhenIsValid()
    {
      var valid = validator.IsValid("pasSw0rdpasSw0rd");
      Assert.True(valid);
    }
  }
}