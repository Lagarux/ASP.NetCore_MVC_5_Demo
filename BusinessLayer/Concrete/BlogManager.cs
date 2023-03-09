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

		public List<Blog> GetBlogById(int id)
		{
			return _ibd.GetListAll(x=> x.BlogID == id);
		}

		public List<Blog> GetLast3Blog()
		{
            return _ibd.GetListAll().Take(3).ToList();
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
			return _ibd.GetListAll(x => x.WriterID == id);
        }

        public List<Blog> GetBlogListWithCategory()
		{
			return _ibd.GetListWithCategory();
		}

        public List<Blog> GetWritersListWithCategory(int id)
        {
            return _ibd.GetListWithCategoryByWriter(id);
        }

        public void AddT(Blog t)
        {
            _ibd.Insert(t);
        }

        public void DeleteT(Blog t)
        {
            _ibd.Delete(t);
        }

        public void UpdateT(Blog t)
        {
            _ibd.Update(t);
        }

        public List<Blog> GetList()
        {
            return _ibd.GetListAll();
        }

        public Blog GetById(int id)
        {
            return _ibd.GetByID(id);
        }
    }
}
