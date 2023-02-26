using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class NewsletterController : Controller
	{
		NewsletterManager NM=new NewsletterManager(new EFNewsletterRepository());
		public PartialViewResult SubscribeMail()
		{
			return PartialView();
		}

		[HttpPost]
		public IActionResult SubscribeMail(Newsletter N)
		{
			N.MailStatus = true;
			NM.AddNewsletter(N);
			Response.Redirect("/Blog/");
			return PartialView();
		}
	}
}
