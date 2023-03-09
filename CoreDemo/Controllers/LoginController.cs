using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CoreDemo.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Writer w)
        {
           Context c= new Context();
            var dataValue=c.Writers.FirstOrDefault(x=>x.WriterMail==w.WriterMail && x.WriterPassword==w.WriterPassword);
            if (dataValue!=null)
            {
                var claims=new List<Claim> 
                { 
                    new Claim(ClaimTypes.Name,w.WriterMail)
                };
                var userIdentity=new ClaimsIdentity(claims,"a");
                ClaimsPrincipal principal=new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index","Writer");
            }
            else
                return View();
        }
    }
}

//Context c = new Context();
//var dataValue = c.Writers.FirstOrDefault(x => x.WriterMail == w.WriterMail && x.WriterPassword == w.WriterPassword);
//if (dataValue != null)
//{
//    HttpContext.Session.SetString("username", w.WriterMail);
//    return RedirectToAction("Index", "Writer");
//}
//else
//    return View();
