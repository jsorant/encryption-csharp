
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace PrimaryRest;

public class RestController : Controller
{
    public async Task<IActionResult> Encrypt(EncryptModel encryptModel)
    {
        var cipher = new CaesarCipher(encryptModel.Shift);
        var encryptedText = cipher.Encrypt(encryptModel.PlainText);
        return View(new EncryptedModel(encryptedText));
    }
}

public record EncryptModel(string PlainText, int Shift);

public record EncryptedModel(string EncryptedText);