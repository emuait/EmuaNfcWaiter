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
			throw new System.NotImplementedException();
		}

		public void Delete(NfcDesk entity)
		{
			throw new System.NotImplementedException();
		}

		public NfcDesk Get(int? id)
		{
			throw new System.NotImplementedException();
		}

		public List<NfcDesk> GetAll()
		{
			return _nfcDeskDal.GetList();
		}

		public NfcDesk Update(NfcDesk entity)
		{
			throw new System.NotImplementedException();
		}
	}
}
