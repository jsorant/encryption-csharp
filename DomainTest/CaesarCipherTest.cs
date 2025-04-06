using Domain;

namespace DomainTest;

public class CaesarCipherTests
{
    [TestCase("Z", 1, "A")]
    [TestCase("Z", 53, "A")]
    [TestCase("A", -1, "Z")]
    [TestCase("A", -53, "Z")]
    [TestCase("ABC", 1, "BCD")]
    public void ShouldEncrypt(String plainText, int shift, String expected)
    {
        var cipher = new CaesarCipher(shift);
        Assert.That(cipher.Encrypt(plainText), Is.EqualTo(expected));
    }
}