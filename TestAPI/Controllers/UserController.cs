using Microsoft.AspNetCore.Mvc;

namespace TestAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    [HttpGet(Name = "CheckUser")]
    public string CheckUser(string userName, string password)
    {
        try
        {
            if (userName != "test_user")
            {
                return "Kullanıcı adı yanlış";
            }

            if (password != "123")
            {
                return "Şifre yanlış";
            }
            
            return "Tebrikler, giriş yaptınız!";
        }
        catch (Exception _)
        {
            return "Bir hata oluştu";
        }
    }
}