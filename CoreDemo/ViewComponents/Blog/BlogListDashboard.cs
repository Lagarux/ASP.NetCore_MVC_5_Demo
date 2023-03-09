using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace CoreDemo.ViewComponents.Blog
{
    public class BlogListDashboard : ViewComponent
    {
        BlogManager BM=new BlogManager(new EFBlogRepository());
        public IViewComponentResult Invoke() 
        {
            var values = BM.GetBlogListWithCategory();
            return View(values);
        }
    }
}
