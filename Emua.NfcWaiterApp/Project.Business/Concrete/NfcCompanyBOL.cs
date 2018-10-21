using Project.Business.Abstract;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using System.Collections.Generic;

namespace Project.Business.Concrete
{
	public class NfcCompanyBOL : INfcCompanyBOL
	{
		private INfcCompanyDAL _nfcCompanyDal;
		public NfcCompanyBOL(INfcCompanyDAL nfcCompanyDal)
		{
			_nfcCompanyDal = nfcCompanyDal;
		}

		public NfcCompany Add(NfcCompany nfcCompany)
		{
			return _nfcCompanyDal.Add(nfcCompany);
		}

		public void Delete(NfcCompany nfcCompany)
		{
			_nfcCompanyDal.Delete(nfcCompany);
		}

		public NfcCompany Get(int? id)
		{
			return _nfcCompanyDal.Get(a => a.Id == id);
		}

		public List<NfcCompany> GetAll()
		{
			return _nfcCompanyDal.GetList();
		}

		public NfcCompany Update(NfcCompany nfcCompany)
		{
			return _nfcCompanyDal.Update(nfcCompany);
		}
	}
}
