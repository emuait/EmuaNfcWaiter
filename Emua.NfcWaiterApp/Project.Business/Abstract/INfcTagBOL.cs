using Project.Entities.Concrete;
using System.Collections.Generic;

namespace Project.Business.Abstract
{
	public interface INfcTagBOL
	{
		List<NfcTag> GetAll();
		List<NfcTag> GetAll(int? companyId);
		List<NfcTag> GetAll(int? companyId, int? deskId);
		List<NfcTag> GetAllInclude();
		List<NfcTag> GetAllInclude(int? companyId);
		List<NfcTag> GetAllInclude(int? companyId, int? deskId);
		NfcTag Get(int? id);
		NfcTag GetInclude(int? id);
		NfcTag Add(NfcTag entity);
		NfcTag Update(NfcTag entity);
		void Delete(NfcTag entity);
	}
}
