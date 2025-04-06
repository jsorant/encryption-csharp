namespace Domain;

public class CaesarCipher
{
    private readonly int _shift;
    private readonly string _alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public CaesarCipher(int shift)
    {
        _shift = shift;
    }

    public String Encrypt(string plainText)
    {
        return _alphabet[_shift].ToString();
    }
}