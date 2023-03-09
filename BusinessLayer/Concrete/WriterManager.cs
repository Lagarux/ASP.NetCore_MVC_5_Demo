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
    public class WriterManager : IWriterService
    {
        IWriterDal IWD;
        public WriterManager(IWriterDal _IWD)
        {
            IWD = _IWD;
        }

        public void AddT(Writer t)
        {
            IWD.Insert(t);
        }

        public void DeleteT(Writer t)
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }
        public Writer GetById(int id)
        {
            return IWD.GetByID(id);
        }
        public void UpdateT(Writer t)
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetWriterByID(int id)
        {
            return IWD.GetListAll(x => x.WriterID == id);
        }
    }
}
