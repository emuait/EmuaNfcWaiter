using Project.Entities.Concrete;
using System.Collections.Generic;

namespace Project.Business.Abstract
{
	public interface INfcDeskCategoryBOL
	{
        List<NfcDeskCategory> GetAll();
		NfcDeskCategory Get(int? id);
		NfcDeskCategory Add(NfcDeskCategory entity);
		NfcDeskCategory Update(NfcDeskCategory entity);
		void Delete(NfcDeskCategory entity);
	}
}
