using Project.Business.Abstract;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using System.Collections.Generic;

namespace Project.Business.Concrete
{
	public class NfcCompanyDeskAlarmBOL : INfcCompanyDeskAlarmBOL
	{
		private string[] includes = new string[] { "NfcCompany", "NfcDesk" };
		private INfcCompanyDeskAlarmDAL _nfcCompanyDeskAlarmDal;
		public NfcCompanyDeskAlarmBOL(INfcCompanyDeskAlarmDAL nfcCompanyDeskAlarmDal)
		{
			_nfcCompanyDeskAlarmDal = nfcCompanyDeskAlarmDal;
		}
		public NfcCompanyDeskAlarm Add(NfcCompanyDeskAlarm entity)
		{
			return _nfcCompanyDeskAlarmDal.Add(entity);
		}

		public void Delete(NfcCompanyDeskAlarm entity)
		{
			_nfcCompanyDeskAlarmDal.Delete(entity);
		}

		public NfcCompanyDeskAlarm Get(int? id)
		{
			return _nfcCompanyDeskAlarmDal.Get(a => a.Id == id);
		}

		public NfcCompanyDeskAlarm GetInclude(int? id)
		{
			return _nfcCompanyDeskAlarmDal.GetInclude(a => a.Id == id, includes);
		}

		public List<NfcCompanyDeskAlarm> GetAll()
		{
			return _nfcCompanyDeskAlarmDal.GetList();
		}

		public List<NfcCompanyDeskAlarm> GetAll(int? companyId)
		{
			return _nfcCompanyDeskAlarmDal.GetList(a => a.CompanyId == companyId);
		}

		public List<NfcCompanyDeskAlarm> GetAll(int? companyId, int? deskId)
		{
			return _nfcCompanyDeskAlarmDal.GetList(a => a.CompanyId == companyId && a.DeskId == deskId);
		}

		public List<NfcCompanyDeskAlarm> GetAllInclude()
		{
			return _nfcCompanyDeskAlarmDal.GetListInclude(null, includes);
		}

		public List<NfcCompanyDeskAlarm> GetAllInclude(int? companyId)
		{
			return _nfcCompanyDeskAlarmDal.GetListInclude(a => a.CompanyId == companyId, includes);
		}

		public List<NfcCompanyDeskAlarm> GetAllInclude(int? companyId, int? deskId)
		{
			return _nfcCompanyDeskAlarmDal.GetListInclude(a => a.CompanyId == companyId && a.DeskId == deskId, includes);
		}

		public NfcCompanyDeskAlarm Update(NfcCompanyDeskAlarm entity)
		{
			return _nfcCompanyDeskAlarmDal.Update(entity);
		}
	}
}
