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
	public class BlogManager : IBlogService
	{
		IBlogDal _ibd;

		public BlogManager(IBlogDal ibd)
		{
			_ibd = ibd;
		}

		public void AddBlog(Blog blog)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetBlogById(int id)
		{
			return _ibd.GetListAll(x=> x.BlogID == id);
		}

		public List<Blog> GetBlogList()
		{
			return _ibd.GetListAll();
		}

        public List<Blog> GetBlogListByWriter(int id)
        {
			return _ibd.GetListAll(x => x.WriterID == id);
        }

        public List<Blog> GetBlogListWithCategory()
		{
			return _ibd.GetListWithCategory();
		}

        public void RemoveBlog(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void UpdateBlog(Blog blog)
		{
			throw new NotImplementedException();
		}
    }
}
