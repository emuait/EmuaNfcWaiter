using Project.Core.DataAccess.EntityFramework;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;

namespace Project.DataAccess.Concrete.EntityFramework
{
	public class EfNfcDeskCategoryDAL : EfEntityRepositoryBase<NfcDeskCategory, dbEmuaNfcContext>, INfcDeskCategoryDAL
	{
	}
}
