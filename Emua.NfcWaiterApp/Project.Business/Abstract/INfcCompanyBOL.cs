using Project.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Business.Abstract
{
	public interface INfcCompanyBOL
	{
		List<NfcCompany> GetAll();
		NfcCompany Get(int? id);
		NfcCompany Add(NfcCompany nfcCompany);
		NfcCompany Update(NfcCompany nfcCompany);
		void Delete(NfcCompany nfcCompany);
	}
}
