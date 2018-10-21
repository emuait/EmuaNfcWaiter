using Project.Entities.Concrete;
using System.Collections.Generic;

namespace Project.Business.Abstract
{
	public interface INfcCompanyDeskAlarmBOL
	{
        List<NfcCompanyDeskAlarm> GetAll();
		NfcCompanyDeskAlarm Get(int? id);
		NfcCompanyDeskAlarm Add(NfcCompanyDeskAlarm entity);
		NfcCompanyDeskAlarm Update(NfcCompanyDeskAlarm entity);
		void Delete(NfcCompanyDeskAlarm entity);
	}
}
