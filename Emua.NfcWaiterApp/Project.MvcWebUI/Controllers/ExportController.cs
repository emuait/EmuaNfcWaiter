using Project.Business.Abstract;
using System.Linq;
using System.Web.Mvc;

namespace Project.MvcWebUI.Controllers
{
	public class ExportController : Controller
	{
		private IEtgMonthlyListReportLineBOL _line;
		private INfcCompanyBOL _nfcCompanyBOL;

		public ExportController(IEtgMonthlyListReportLineBOL line, INfcCompanyBOL nfcCompanyBOL)
		{
			_line = line;
			_nfcCompanyBOL = nfcCompanyBOL;
		}
		public ActionResult Index()
		{
			return View();
		}
		public ActionResult EtgMonthlyListReportLine()
		{
			if (ModelState.IsValid)
			{
				var model = _line.GetAll().Take(100);
				var model1 = _nfcCompanyBOL.GetAll();
				return View(model);
			}
			return RedirectToAction("Index");
		}
	}
}