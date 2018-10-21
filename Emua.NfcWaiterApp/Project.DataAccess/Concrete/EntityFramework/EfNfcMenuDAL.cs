using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Project.Core.DataAccess.EntityFramework;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;

namespace Project.DataAccess.Concrete.EntityFramework
{
	public class EfNfcMenuDAL : EfEntityRepositoryBase<NfcMenu, dbEmuaNfcContext>, INfcMenuDAL
	{
	}
}
