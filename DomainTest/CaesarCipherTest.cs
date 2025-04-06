using Domain;

namespace DomainTest;

public class CaesarCipherTests
{
    [TestCase("A", 0, "A")]
    [TestCase("A", 1, "B")]
    [TestCase("A", 2, "C")]
    [TestCase("B", 1, "C")]
    [TestCase("B", 2, "D")]
    [TestCase("Z", 1, "A")]
    [TestCase("Z", 53, "A")]
    [TestCase("B", -1, "A")]
    [TestCase("A", -1, "Z")]
    [TestCase("A", -53, "Z")]
    public void ShouldEncrypt(String plainText, int shift, String expected)
    {
        var cipher = new CaesarCipher(shift);
        Assert.That(cipher.Encrypt(plainText), Is.EqualTo(expected));
    }
}