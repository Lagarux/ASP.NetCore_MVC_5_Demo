using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class NewsletterManager : INewsletterService
	{
		INewsletterDal IND;
		public NewsletterManager(INewsletterDal _ind)
		{
			IND = _ind;
		}

		public void AddNewsletter(Newsletter newsletter)
		{
			IND.Insert(newsletter);
		}
	}
}
