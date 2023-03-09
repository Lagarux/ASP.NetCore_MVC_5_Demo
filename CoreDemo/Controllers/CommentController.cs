using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class CommentController : Controller
	{
		CommentManager cm = new CommentManager(new EFCommentRepository());
		[HttpGet]
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}

		[HttpPost]
		public PartialViewResult PartialAddComment(Comment c)
		{
			c.CommentDate= DateTime.Parse(DateTime.Now.ToShortDateString());
			c.CommentStatus = true;
			c.BlogID = BlogController.BI;
			cm.AddT(c);
			Response.Redirect("/Blog/BlogReadAll/"+c.BlogID);
			return PartialView();
		}

		public PartialViewResult CommentListByBlog(int id)
		{
			var values=cm.GetCommentList(id);
			return PartialView(values);
		}
	}
}
