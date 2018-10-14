using Ninject.Modules;
using Project.Business.Abstract;
using Project.Business.Concrete;
using Project.Core.DataAccess;
using Project.Core.DataAccess.EntityFramework;
using Project.DataAccess.Abstract;
using Project.DataAccess.Concrete.EntityFramework;
using Project.Entities.Concrete;
using System.Data.Entity;

namespace Project.Business.DependecyResolvers.Ninject
{
	public class BusinessModule : NinjectModule
	{
		public override void Load()
		{
			Bind<IEtgMonthlyListReportLineDAL>().To<EfEtgMonthlyListReportLineDAL>();
			Bind<IEtgMonthlyListReportLineBOL>().To<EtgMonthlyListReportLineBOL>();
			Bind<INfcCompanyDAL>().To<EfNfcCompanyDAL>();
			Bind<INfcCompanyBOL>().To<NfcCompanyBOL>();

			Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
			Bind<DbContext>().To<EmuaNfcContext>();
		}
	}
}
