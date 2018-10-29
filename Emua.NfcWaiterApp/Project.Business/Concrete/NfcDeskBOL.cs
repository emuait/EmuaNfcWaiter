using Project.Business.Abstract;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using System.Collections.Generic;

namespace Project.Business.Concrete
{
	public class NfcDeskBOL : INfcDeskBOL
	{
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

		public List<NfcDesk> GetAll(int? companyId)
		{
			return _nfcDeskDal.GetList(a => a.CompanyId == companyId);
		}

		public List<NfcDesk> GetAll(int? companyId, int? deskCategoryId)
		{
			return _nfcDeskDal.GetList(a => a.CompanyId == companyId && a.DeskCategoryId == deskCategoryId);
		}

		public NfcDesk Update(NfcDesk entity)
		{
			return _nfcDeskDal.Update(entity);
		}

		public List<NfcDesk> GetAllInclude(string[] includes)
		{
			return _nfcDeskDal.GetListInclude(null, includes);
		}

		public NfcDesk GetInclude(int? id, string[] includes)
		{
			return _nfcDeskDal.GetInclude(a => a.Id == id, includes);
		}
	}
}
