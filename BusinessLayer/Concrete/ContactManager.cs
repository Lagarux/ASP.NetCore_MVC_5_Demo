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
	public class ContactManager : IContactService
	{
		IContactDal ICD;

		public ContactManager(IContactDal _icd)
		{
			ICD = _icd;
		}

		public void ContactAdd(Contact contact)
		{
			ICD.Insert(contact);
		}
	}
}
