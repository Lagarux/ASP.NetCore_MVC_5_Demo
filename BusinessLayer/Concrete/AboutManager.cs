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
	public class AboutManager : IAboutService
	{
		IAboutDal IAD;

		public AboutManager(IAboutDal _iad)
		{
			IAD = _iad;
		}

        public void AddT(About t)
        {
            throw new NotImplementedException();
        }

        public void DeleteT(About t)
        {
            throw new NotImplementedException();
        }

        public About GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> GetList()
		{
			return IAD.GetListAll();
		}

        public void UpdateT(About t)
        {
            throw new NotImplementedException();
        }
    }
}
