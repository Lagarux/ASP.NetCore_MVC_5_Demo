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

        public void AddWriter(Writer writer)
        {
            IWD.Insert(writer);
        }

        public Writer GetWriterById(int id)
        {
            return IWD.GetByID(id);
        }

        public List<Writer> GetWriterList()
        {
            throw new NotImplementedException();
        }

        public void RemoveWriter(Writer writer)
        {
            throw new NotImplementedException();
        }

        public void UpdateWriter(Writer writer)
        {
            throw new NotImplementedException();
        }
    }
}
