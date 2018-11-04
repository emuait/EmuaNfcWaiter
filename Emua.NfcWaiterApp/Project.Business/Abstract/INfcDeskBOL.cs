using Project.Entities.Concrete;
using System.Collections.Generic;

namespace Project.Business.Abstract
{
	public interface INfcDeskBOL
	{
		List<NfcDesk> GetAll();
		List<NfcDesk> GetAll(int? companyId);
		List<NfcDesk> GetAll(int? companyId, int? deskCategoryId);
		List<NfcDesk> GetAllInclude();
		List<NfcDesk> GetAllInclude(int? companyId);
		List<NfcDesk> GetAllInclude(int? companyId, int? deskCategoryId);
		NfcDesk Get(int? id);
		NfcDesk GetInclude(int? id);
		NfcDesk Add(NfcDesk entity);
		NfcDesk Update(NfcDesk entity);
		void Delete(NfcDesk entity);
	}
}
