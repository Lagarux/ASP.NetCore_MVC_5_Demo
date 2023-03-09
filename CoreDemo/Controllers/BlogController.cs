using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager BM=new BlogManager(new EFBlogRepository());
        WriterManager WM=new WriterManager(new EFWriterRepository());
        CategoryManager CM=new CategoryManager(new EFCategoryRepository());
        public static int BI;
        public static DateTime cbd;
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

        public IActionResult BlogListByWriter()
        {
            var values=BM.GetWritersListWithCategory(1);
            //var cat=CM.GetCategoryById(values.Select(x=>x.CategoryID).FirstOrDefault());
            //ViewBag.categoryName = cat.CategoryName;
            return View(values);
        }

        List<SelectListItem> categoryValues;
        [HttpGet]
        public IActionResult BlogAdd()
        {
            categoryValues = (from x in CM.GetList()
                              select new SelectListItem
                              {
                                  Text = x.CategoryName,
                                  Value = x.CategoryID.ToString()

                              }).ToList();

            ViewData["cv"] = categoryValues;
            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog b)
        {
            BlogValidator BV=new BlogValidator();
            ValidationResult result=BV.Validate(b);
            categoryValues = (from x in CM.GetList()
                              select new SelectListItem
                              {
                                  Text = x.CategoryName,
                                  Value = x.CategoryID.ToString()

                              }).ToList();
            ViewData["cv"] = categoryValues;
            if (result.IsValid)
            {
                b.BlogStatus = true;
                b.BlogCreateDate= DateTime.Parse(DateTime.Now.ToShortDateString());
                b.WriterID = 1;
                BM.AddT(b);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                ModelState.Clear();
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeleteBlog(int id)
        {
            var blogValue=BM.GetById(id);
            BM.DeleteT(blogValue);
            return RedirectToAction("BlogListByWriter","Blog");
        }

        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            var blogValue = BM.GetById(id);
            List<SelectListItem> categoryValues = (from x in CM.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()

                                                   }).ToList();
            ViewData["cv"] = categoryValues;
            cbd=blogValue.BlogCreateDate;
            return View(blogValue);
        }
        [HttpPost]
        public IActionResult EditBlog(Blog B)
        {
            B.BlogCreateDate = cbd;
            BM.UpdateT(B);
            return RedirectToAction("BlogListByWriter","Blog");
        }

        private List<Blog> GetBlogs(int id) 
        {
			var values = BM.GetBlogById(id);
			var BlogWriter = WM.GetById(values.Select(x => x.WriterID).FirstOrDefault());
			ViewBag.WriterName = BlogWriter.WriterName.ToString();
            return values;
		}


    }
}
