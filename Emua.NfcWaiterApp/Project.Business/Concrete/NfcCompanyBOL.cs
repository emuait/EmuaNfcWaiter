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
		public List<NfcCompany> GetAll()
		{
			return _nfcCompanyDal.GetList();
		}
	}
}
