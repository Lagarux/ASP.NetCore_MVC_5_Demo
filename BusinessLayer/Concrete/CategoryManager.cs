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

        public void AddCategory(Category category)
        { 
           catDal.Insert(category);
        }

        public Category GetCategoryById(int id)
        {
           return catDal.GetByID(id);
        }

        public List<Category> GetCategoryList()
        {
           return catDal.GetListAll();
        }

        public void RemoveCategory(Category category)
        {
            catDal.Delete(category);
        }

        public void UpdateCategory(Category category)
        {
            catDal.Update(category);
        }
    }
}
