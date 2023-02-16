using BusinessLayer.Abstract;
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
        EFCategoryRepository EFCR;

        public CategoryManager()
        {
            EFCR= new EFCategoryRepository();
        }
        public void AddCategory(Category category)
        { 
           EFCR.Insert(category);
        }

        public Category GetCategoryById(int id)
        {
           return EFCR.GetByID(id);
        }

        public List<Category> GetCategoryList()
        {
           return EFCR.GetListAll();
        }

        public void RemoveCategory(Category category)
        {
            EFCR.Delete(category);
        }

        public void UpdateCategory(Category category)
        {
            EFCR.Update(category);
        }
    }
}
