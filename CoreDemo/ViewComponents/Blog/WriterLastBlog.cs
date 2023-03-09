using BusinessLayer.Concrete;
using CoreDemo.Controllers;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Blog
{
    public class WriterLastBlog : ViewComponent
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());

        public IViewComponentResult Invoke()
        {
            var blogValue = bm.GetBlogById(BlogController.BI).Select(x => x.WriterID).FirstOrDefault();
            var values = bm.GetBlogListByWriter(blogValue);
            return View(values);
        }
    }
}
