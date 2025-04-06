using System.Text;

namespace Domain;

public class CaesarCipher(int shift)
{
    private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public string Encrypt(string plainText)
    {
        return plainText.Select(EncryptCharacter)
            .Aggregate(new StringBuilder(), (sb, encryptedChar) => sb.Append(encryptedChar))
            .ToString();
    }

    private string EncryptCharacter(char plainChar)
    {
        var sourceIndex = Alphabet.IndexOf(plainChar);
        var destinationIndex = ComputeDestinationIndexInAlphabetRange(sourceIndex);
        return Alphabet[destinationIndex].ToString();
    }

    private int ComputeDestinationIndexInAlphabetRange(int sourceIndex)
    {
        var destinationIndexInAlphabetRange = (sourceIndex + shift) % Alphabet.Length;
        if(destinationIndexInAlphabetRange < 0) destinationIndexInAlphabetRange += Alphabet.Length;
        return destinationIndexInAlphabetRange;
    }
}