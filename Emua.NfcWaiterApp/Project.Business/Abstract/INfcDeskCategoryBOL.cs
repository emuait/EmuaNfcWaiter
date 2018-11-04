using Project.Entities.Concrete;
using System.Collections.Generic;

namespace Project.Business.Abstract
{
	public interface INfcDeskCategoryBOL
	{
        List<NfcDeskCategory> GetAll();
		List<NfcDeskCategory> GetAll(int? companyId);
		List<NfcDeskCategory> GetAllInclude();
		List<NfcDeskCategory> GetAllInclude(int? companyId);
		NfcDeskCategory Get(int? id);
		NfcDeskCategory GetInclude(int? id);
		NfcDeskCategory Add(NfcDeskCategory entity);
		NfcDeskCategory Update(NfcDeskCategory entity);
		void Delete(NfcDeskCategory entity);
	}
}
