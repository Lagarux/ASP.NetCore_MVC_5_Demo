using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.Identity.Client.Utils.Windows;
using CoreDemo.Helper;
using CoreDemo.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CoreDemo.Controllers
{
	public class RegisterController : Controller
	{
		WriterManager wm=new WriterManager(new EFWriterRepository());

		[HttpGet]
		public IActionResult Index()
		{
			callList();
			return View();
		}

		[HttpPost]
		public IActionResult Index(Writer w)
		{
			WriterValidator WV= new WriterValidator();
			ValidationResult result=WV.Validate(w);
			if(result.IsValid)
			{
                w.WriterStatus = true;
				if(w.WriterImage==null)
				{
					w.WriterImage = "Standart Profil Fotoğrafı";
				}
                wm.AddWriter(w);
                return RedirectToAction("Index", "Blog");
            }
			else
			{
                ModelState.Clear();
                foreach (var item in result.Errors)
				{						
						ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			callList();
			return View();
		}

		public void callList()
		{
            var cities = Cities.GetAll();
            var model = new RegisterViewModel();
            model.CitiesSelectList = new List<SelectListItem>();

            foreach (var city in cities)
            {
                model.CitiesSelectList.Add(new SelectListItem { Text = city.Name, Value = city.Id.ToString() });
            }
            ViewData["Cities"] = model.CitiesSelectList;
        }
	}
}
