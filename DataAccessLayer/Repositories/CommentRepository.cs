using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    internal class CommentRepository : IGenericDal<Comment>
    {
        Context c=new Context();
        public void Delete(Comment t)
        {
            c.Remove(t);
            c.SaveChanges();
        }

        public Comment GetByID(int id)
        {
            return c.Comments.Find(id);
        }

        public List<Comment> GetListAll()
        {
            return c.Comments.ToList();
        }

        public void Insert(Comment t)
        {
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(Comment t)
        {
            c.Update(t);
            c.SaveChanges();
        }
    }
}
