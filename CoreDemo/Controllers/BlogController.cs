using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager BM=new BlogManager(new EFBlogRepository());
        WriterManager WM=new WriterManager(new EFWriterRepository());
        public static int BI;
        public IActionResult Index()
        {
            var values=BM.GetBlogListWithCategory();
            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {
            BI = id;
            ViewBag.I = id;
            return View(GetBlogs(id));
        }

        private List<Blog> GetBlogs(int id) 
        {
			var values = BM.GetBlogById(id);
			var BlogWriter = WM.GetWriterById(values.Select(x => x.WriterID).FirstOrDefault());
			ViewBag.WriterName = BlogWriter.WriterName.ToString();
            return values;
		}
    }
}
