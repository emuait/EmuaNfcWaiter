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
			Bind<INfcCompanyDAL>().To<EfNfcCompanyDAL>();
			Bind<INfcCompanyBOL>().To<NfcCompanyBOL>();

			Bind<INfcDeskDAL>().To<EfNfcDeskDAL>();
			Bind<INfcDeskBOL>().To<NfcDeskBOL>();

			Bind<INfcDeskCategoryDAL>().To<EfNfcDeskCategoryDAL>();
			Bind<INfcDeskCategoryBOL>().To<NfcDeskCategoryBOL>();

			Bind<INfcCompanyDeskAlarmDAL>().To<EfNfcCompanyDeskAlarmDAL>();
			Bind<INfcCompanyDeskAlarmBOL>().To<NfcCompanyDeskAlarmBOL>();

			Bind<INfcMenuDAL>().To<EfNfcMenuDAL>();
			Bind<INfcMenuBOL>().To<NfcMenuBOL>();

			Bind<INfcTagDAL>().To<EfNfcTagDAL>();
			Bind<INfcTagBOL>().To<NfcTagBOL>();

			Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
			Bind<DbContext>().To<dbEmuaNfcContext>();
		}
	}
}
