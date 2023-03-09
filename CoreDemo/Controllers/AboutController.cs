using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class AboutController : Controller
	{
		AboutManager _abm=new AboutManager(new EFAboutRepository());
		public IActionResult Index()
		{
			var values = _abm.GetList();
			return View(values);
		}

		public PartialViewResult SocialMediaAbout()
		{
			return PartialView();
		}
	}
}
