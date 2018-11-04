using Project.Business.Abstract;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using System.Collections.Generic;

namespace Project.Business.Concrete
{
	public class NfcDeskCategoryBOL : INfcDeskCategoryBOL
	{
		private string[] includes = new string[] { "NfcCompany" };
		private INfcDeskCategoryDAL _nfcDeskCategoryDal;
		public NfcDeskCategoryBOL(INfcDeskCategoryDAL nfcDeskCategoryDal)
		{
			_nfcDeskCategoryDal = nfcDeskCategoryDal;
		}
		public NfcDeskCategory Add(NfcDeskCategory entity)
		{
			return _nfcDeskCategoryDal.Add(entity);
		}

		public void Delete(NfcDeskCategory entity)
		{
			_nfcDeskCategoryDal.Delete(entity);
		}

		public NfcDeskCategory Get(int? id)
		{
			return _nfcDeskCategoryDal.Get(a => a.Id == id);
		}

		public NfcDeskCategory GetInclude(int? id)
		{
			return _nfcDeskCategoryDal.GetInclude(a => a.Id == id);
		}

		public List<NfcDeskCategory> GetAll()
		{
			return _nfcDeskCategoryDal.GetList();
		}

		public List<NfcDeskCategory> GetAll(int? companyId)
		{
			return _nfcDeskCategoryDal.GetList(a => a.CompanyId == companyId);
		}

		public List<NfcDeskCategory> GetAllInclude()
		{
			return _nfcDeskCategoryDal.GetListInclude(null, includes);
		}

		public List<NfcDeskCategory> GetAllInclude(int? companyId)
		{
			return _nfcDeskCategoryDal.GetListInclude(a => a.CompanyId == companyId, includes);
		}

		public NfcDeskCategory Update(NfcDeskCategory entity)
		{
			return _nfcDeskCategoryDal.Update(entity);
		}
	}
}
