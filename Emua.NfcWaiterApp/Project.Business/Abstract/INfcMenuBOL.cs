using Project.Entities.Concrete;
using System.Collections.Generic;

namespace Project.Business.Abstract
{
	public interface INfcMenuBOL
	{
		List<NfcMenu> GetAll();
		NfcMenu Get(int? id);
		NfcMenu Add(NfcMenu entity);
		NfcMenu Update(NfcMenu entity);
		void Delete(NfcMenu entity);
	}
}
