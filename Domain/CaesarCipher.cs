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
        int sourceIndex = _alphabet.IndexOf(plainText[0]);
        int destinationIndex = ComputeDestinationIndexInAlphabetRange(sourceIndex);
        return _alphabet[destinationIndex].ToString();
    }

    private int ComputeDestinationIndexInAlphabetRange(int sourceIndex)
    {
        int destinationIndexInAlphabetRange = (sourceIndex + _shift) % _alphabet.Length;
        if(destinationIndexInAlphabetRange < 0) destinationIndexInAlphabetRange += _alphabet.Length;
        return destinationIndexInAlphabetRange;
    }
}