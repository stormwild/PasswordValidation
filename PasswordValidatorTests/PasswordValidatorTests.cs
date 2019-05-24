using System;
using Xunit;

namespace PasswordValidatorTests
{
  public class PasswordValidatorTests
  {
    private PasswordValidator.PasswordValidator validator = new PasswordValidator.PasswordValidator();

    [Fact]
    public void ReturnsTrueWhenHasUppercase()
    {
      var valid = validator.HasUppercase("pasSw0rdpasSw0rd");
      Assert.True(valid);
    }

    [Fact]
    public void ReturnsTrueWhenHaslowercase()
    {
      var valid = validator.HasLowercase("pasSw0rdpasSw0rd");
      Assert.True(valid);
    }

    [Fact]
    public void ReturnsTrueWhenHasDigit()
    {
      var valid = validator.HasDigit("pasSw0rdpasSw0rd");
      Assert.True(valid);
    }

    [Fact]
    public void ReturnsTrueWhenHasMinLengthTwelve()
    {
      var valid = validator.HasMinLengthTwelve("pasSw0rdpasSw0rd");
      Assert.True(valid);
    }

    [Fact]
    public void ReturnsTrueWhenIsValid()
    {
      var valid = validator.IsValid("pasSw0rdpasSw0rd");
      Assert.True(valid);
    }
  }
}
