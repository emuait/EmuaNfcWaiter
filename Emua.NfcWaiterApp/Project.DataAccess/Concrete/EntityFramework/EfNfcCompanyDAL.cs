using Project.Core.DataAccess.EntityFramework;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;

namespace Project.DataAccess.Concrete.EntityFramework
{
	public class EfNfcCompanyDAL : EfEntityRepositoryBase<NfcCompany, EmuaNfcContext>, INfcCompanyDAL
	{
	}
}
