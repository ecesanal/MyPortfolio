using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;


namespace MyPortfolio.Controllers
{
    [Route("logout")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            // Kullanıcıyı çıkış yaptır
            await HttpContext.SignOutAsync();

            // İsteğe bağlı olarak, kullanıcıyı ana sayfaya yönlendirebilir veya başarı mesajı dönebilirsiniz
            return Ok(new { message = "Başarıyla çıkış yaptınız." });
        }
    }
}
