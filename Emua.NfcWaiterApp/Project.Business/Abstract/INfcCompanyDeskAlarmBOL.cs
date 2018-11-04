using Project.Entities.Concrete;
using System.Collections.Generic;

namespace Project.Business.Abstract
{
	public interface INfcCompanyDeskAlarmBOL
	{
		List<NfcCompanyDeskAlarm> GetAll();
		List<NfcCompanyDeskAlarm> GetAll(int? companyId);
		List<NfcCompanyDeskAlarm> GetAll(int? companyId, int? deskCategoryId);
		List<NfcCompanyDeskAlarm> GetAllInclude();
		List<NfcCompanyDeskAlarm> GetAllInclude(int? companyId);
		List<NfcCompanyDeskAlarm> GetAllInclude(int? companyId, int? deskCategoryId);
		NfcCompanyDeskAlarm Get(int? id);
		NfcCompanyDeskAlarm GetInclude(int? id);
		NfcCompanyDeskAlarm Add(NfcCompanyDeskAlarm entity);
		NfcCompanyDeskAlarm Update(NfcCompanyDeskAlarm entity);
		void Delete(NfcCompanyDeskAlarm entity);
	}
}
