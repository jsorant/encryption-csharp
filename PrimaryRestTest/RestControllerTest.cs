
using Microsoft.AspNetCore.Mvc;
using PrimaryRest;

namespace PrimaryRestTest;

public class Tests
{
    [Test]
    public async Task TestEncryptRoute()
    {
        var controller = new RestController();

        var encryptModel = new EncryptModel("ABC", 2);
        
        var result = await controller.Encrypt(encryptModel);
        
        var viewResult = result as ViewResult;
        Assert.That(viewResult, Is.Not.Null);
        
        var model = viewResult.ViewData.Model as EncryptedModel;
        Assert.That(model, Is.Not.Null);
        Assert.That(model.EncryptedText, Is.EqualTo("CDE"));
    }
}