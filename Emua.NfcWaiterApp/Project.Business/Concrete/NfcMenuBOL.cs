using Project.Business.Abstract;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using System.Collections.Generic;

namespace Project.Business.Concrete
{
	public class NfcMenuBOL : INfcMenuBOL
	{
		private string[] includes = new string[] { "NfcCompany" };
		private INfcMenuDAL _nfcMenuDal;
		public NfcMenuBOL(INfcMenuDAL nfcMenuDal)
		{
			_nfcMenuDal = nfcMenuDal;
		}
		public NfcMenu Add(NfcMenu entity)
		{
			return _nfcMenuDal.Add(entity);
		}

		public void Delete(NfcMenu entity)
		{
			_nfcMenuDal.Delete(entity);
		}

		public NfcMenu Get(int? id)
		{
			return _nfcMenuDal.Get(a => a.Id == id);
		}

		public NfcMenu GetInclude(int? id)
		{
			return _nfcMenuDal.GetInclude(a => a.Id == id, includes);
		}

		public List<NfcMenu> GetAll(int? companyId)
		{
			return _nfcMenuDal.GetList(a => a.CompanyId == companyId);
		}

		public List<NfcMenu> GetAllInclude(int? companyId)
		{
			return _nfcMenuDal.GetListInclude(a => a.CompanyId == companyId, includes);
		}

		public NfcMenu Update(NfcMenu entity)
		{
			return _nfcMenuDal.Update(entity);
		}
	}
}
