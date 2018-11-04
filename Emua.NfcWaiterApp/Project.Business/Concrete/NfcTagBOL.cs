using Project.Business.Abstract;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using System.Collections.Generic;

namespace Project.Business.Concrete
{
	public class NfcTagBOL : INfcTagBOL
	{
		private string[] includes = new string[] { "NfcCompany", "NfcDesk" };
		private INfcTagDAL _nfcTagDal;
		public NfcTagBOL(INfcTagDAL nfcTagDal)
		{
			_nfcTagDal = nfcTagDal;
		}

		public NfcTag Add(NfcTag entity)
		{
			return _nfcTagDal.Add(entity);
		}

		public void Delete(NfcTag entity)
		{
			_nfcTagDal.Delete(entity);
		}

		public NfcTag Get(int? id)
		{
			return _nfcTagDal.Get(a => a.Id == id);
		}

		public NfcTag GetInclude(int? id)
		{
			return _nfcTagDal.GetInclude(a => a.Id == id, includes);
		}

		public List<NfcTag> GetAll()
		{
			return _nfcTagDal.GetList();
		}

		public List<NfcTag> GetAll(int? companyId)
		{
			return _nfcTagDal.GetList(a => a.CompanyId == companyId);
		}

		public List<NfcTag> GetAll(int? companyId, int? deskId)
		{
			return _nfcTagDal.GetList(a => a.CompanyId == companyId && a.DeskId == deskId);
		}

		public List<NfcTag> GetAllInclude()
		{
			return _nfcTagDal.GetListInclude(null, includes);
		}

		public List<NfcTag> GetAllInclude(int? companyId)
		{
			return _nfcTagDal.GetListInclude(a => a.CompanyId == companyId, includes);
		}

		public List<NfcTag> GetAllInclude(int? companyId, int? deskId)
		{
			return _nfcTagDal.GetListInclude(a => a.CompanyId == companyId && a.DeskId == deskId, includes);
		}

		public NfcTag Update(NfcTag entity)
		{
			return _nfcTagDal.Update(entity);
		}
	}
}
