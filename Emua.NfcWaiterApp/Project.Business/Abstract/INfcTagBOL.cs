using Project.Entities.Concrete;
using System.Collections.Generic;

namespace Project.Business.Abstract
{
	public interface INfcTagBOL
	{
		List<NfcTag> GetAll();
		NfcTag Get(int? id);
		NfcTag Add(NfcTag entity);
		NfcTag Update(NfcTag entity);
		void Delete(NfcTag entity);
	}
}
