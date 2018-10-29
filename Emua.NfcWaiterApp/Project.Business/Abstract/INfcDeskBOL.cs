using Project.Entities.Concrete;
using System.Collections.Generic;

namespace Project.Business.Abstract
{
	public interface INfcDeskBOL
	{
		List<NfcDesk> GetAll();
		List<NfcDesk> GetAllInclude(string[] includes);
		List<NfcDesk> GetAll(int? companyId);
		List<NfcDesk> GetAll(int? companyId, int? deskCategoryId);
		NfcDesk Get(int? id);
		NfcDesk GetInclude(int? id, string[] includes);
		NfcDesk Add(NfcDesk entity);
		NfcDesk Update(NfcDesk entity);
		void Delete(NfcDesk entity);
	}
}
