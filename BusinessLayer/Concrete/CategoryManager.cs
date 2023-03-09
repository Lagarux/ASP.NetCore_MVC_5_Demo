using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal catDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            catDal = categoryDal;
        }

        public void AddT(Category t)
        {
             catDal.Insert(t);
        }

        public void DeleteT(Category t)
        {
            catDal.Delete(t);
        }

        public void UpdateT(Category t)
        {
            catDal.Update(t);
        }

        public Category GetById(int id)
        {
            return catDal.GetByID(id);
        }

        public List<Category> GetList()
        {
            return catDal.GetListAll();
        }


        //public void RemoveCategory(Category category)
        //{
        //    catDal.Delete(category);
        //}

        //public void UpdateCategory(Category category)
        //{
        //    catDal.Update(category);
        //}


    }
}
