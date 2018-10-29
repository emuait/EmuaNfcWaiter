using System.Collections.Generic;
using Project.Core.DataAccess.EntityFramework;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;

namespace Project.DataAccess.Concrete.EntityFramework
{
	public class EfNfcDeskDAL : EfEntityRepositoryBase<NfcDesk, dbEmuaNfcContext>, INfcDeskDAL
	{
	}
}
