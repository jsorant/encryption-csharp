using Domain;

namespace DomainTest;

public class CaesarCipherTests
{
    [TestCase("A", 0, "A")]
    [TestCase("A", 1, "B")]
    [TestCase("A", 2, "C")]
    public void ShouldEncrypt(String plainText, int shift, String expected)
    {
        var cipher = new CaesarCipher(shift);
        Assert.That(cipher.Encrypt(plainText), Is.EqualTo(expected));
    }
}