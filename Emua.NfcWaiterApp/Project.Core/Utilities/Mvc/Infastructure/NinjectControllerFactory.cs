using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;

namespace Project.Core.Utilities.Mvc.Infastructure
{
	//NinjectControllerFactory Yazımı
	public class NinjectControllerFactory : DefaultControllerFactory
	{
		private IKernel _kernel;

		public NinjectControllerFactory(INinjectModule module)
		{
			_kernel = new StandardKernel(module);
		}

		protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
		{
			return controllerType == null ? null : (IController)_kernel.Get((controllerType));
		}
	}
}
