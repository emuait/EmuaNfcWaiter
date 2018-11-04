using Project.Business.Abstract;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using System.Collections.Generic;

namespace Project.Business.Concrete
{
	public class NfcDeskBOL : INfcDeskBOL
	{
		private string[] includes = new string[] { "NfcCompany", "NfcDeskCategory" };
		private INfcDeskDAL _nfcDeskDal;
		public NfcDeskBOL(INfcDeskDAL nfcDeskDal)
		{
			_nfcDeskDal = nfcDeskDal;
		}
		public NfcDesk Add(NfcDesk entity)
		{
			return _nfcDeskDal.Add(entity);
		}

		public void Delete(NfcDesk entity)
		{
			_nfcDeskDal.Delete(entity);
		}

		public List<NfcDesk> GetAll()
		{
			return _nfcDeskDal.GetList();
		}

		public NfcDesk Get(int? id)
		{
			return _nfcDeskDal.Get(a => a.Id == id);
		}

		public NfcDesk GetInclude(int? id)
		{
			return _nfcDeskDal.GetInclude(a => a.Id == id, includes);
		}

		public List<NfcDesk> GetAll(int? companyId)
		{
			return _nfcDeskDal.GetList(a => a.CompanyId == companyId);
		}

		public List<NfcDesk> GetAll(int? companyId, int? deskCategoryId)
		{
			return _nfcDeskDal.GetList(a => a.CompanyId == companyId && a.DeskCategoryId == deskCategoryId);
		}

		public List<NfcDesk> GetAllInclude()
		{
			return _nfcDeskDal.GetListInclude(null, includes);
		}

		public List<NfcDesk> GetAllInclude(int? companyId)
		{
			return _nfcDeskDal.GetListInclude(a => a.CompanyId == companyId, includes);
		}

		public List<NfcDesk> GetAllInclude(int? companyId, int? deskCategoryId)
		{
			return _nfcDeskDal.GetListInclude(a => a.CompanyId == companyId && a.DeskCategoryId == deskCategoryId, includes);
		}

		public NfcDesk Update(NfcDesk entity)
		{
			return _nfcDeskDal.Update(entity);
		}
	}
}
