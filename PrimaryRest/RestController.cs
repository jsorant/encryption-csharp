
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace PrimaryRest;

public class RestController : Controller
{
    public Task<IActionResult> Encrypt(EncryptModel encryptModel)
    {
        var cipher = new CaesarCipher(encryptModel.Shift);
        var encryptedText = cipher.Encrypt(encryptModel.PlainText);
        var encryptedModel = ToResponse(encryptedText);
        return Task.FromResult<IActionResult>(View(encryptedModel));
    }

    private static EncryptedModel ToResponse(string encryptedText)
    {
        return new EncryptedModel(encryptedText);
    }
}

public record EncryptModel(string PlainText, int Shift);

public record EncryptedModel(string EncryptedText);