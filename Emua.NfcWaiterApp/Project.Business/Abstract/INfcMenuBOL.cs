using Project.Entities.Concrete;
using System.Collections.Generic;

namespace Project.Business.Abstract
{
	public interface INfcMenuBOL
	{
		List<NfcMenu> GetAll(int? companyId);
		List<NfcMenu> GetAllInclude(int? companyId);
		NfcMenu Get(int? id);
		NfcMenu GetInclude(int? id);
		NfcMenu Add(NfcMenu entity);
		NfcMenu Update(NfcMenu entity);
		void Delete(NfcMenu entity);
	}
}
