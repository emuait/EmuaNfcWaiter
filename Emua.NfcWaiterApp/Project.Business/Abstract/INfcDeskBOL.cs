using Project.Entities.Concrete;
using System.Collections.Generic;

namespace Project.Business.Abstract
{
	public interface INfcDeskBOL
	{
		List<NfcDesk> GetAll();
		NfcDesk Get(int? id);
		NfcDesk Add(NfcDesk entity);
		NfcDesk Update(NfcDesk entity);
		void Delete(NfcDesk entity);
	}
}
