using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreDemo.Models.ViewModels
{
	public class RegisterViewModel
	{
		public string SelectedCity { get; set; }

		//Display Property
		public List<SelectListItem> CitiesSelectList { get; set; }
	}
}
