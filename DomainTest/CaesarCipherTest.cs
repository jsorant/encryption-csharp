using Domain;

namespace DomainTest;

public class CaesarCipherTests
{
    [Test]
    public void ShouldEncryptWithShift0()
    {
        var cipher = new CaesarCipher(0);
        Assert.That(cipher.Encrypt("a"), Is.EqualTo("a"));
    }
}