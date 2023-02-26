using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CommentManager : ICommentService
	{
		ICommentDal ICD;

		public CommentManager(ICommentDal icd)
		{
			ICD = icd;
		}

		public void AddComment(Comment comment)
		{
			ICD.Insert(comment);
		}

		public List<Comment> GetCommentList(int id)
		{
			return ICD.GetListAll(x=> x.BlogID == id);
		}
	}
}
