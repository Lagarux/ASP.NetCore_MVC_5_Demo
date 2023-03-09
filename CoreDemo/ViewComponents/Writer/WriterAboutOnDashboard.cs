using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Writer
{
    
    public class WriterAboutOnDashboard : ViewComponent
    {
        WriterManager WM = new WriterManager(new EFWriterRepository());

        public IViewComponentResult Invoke()
        {
            var values = WM.GetWriterByID(1);
            return View(values);
        }
    }
}
