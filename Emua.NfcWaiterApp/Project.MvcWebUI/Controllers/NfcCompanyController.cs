using Project.Business.Abstract;
using Project.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MvcWebUI.Controllers
{
	public class NfcCompanyController : Controller
	{
		private INfcCompanyBOL _nfcCompanyBol;
		public NfcCompanyController(INfcCompanyBOL nfcCompanyBol)
		{
			_nfcCompanyBol = nfcCompanyBol;
		}
		public ActionResult Index()
		{
			if (ModelState.IsValid)
			{
				NfcCompanyViewModel vm = new NfcCompanyViewModel();
				vm.listNfcCompany = _nfcCompanyBol.GetAll();
				return View(vm);
			}
			return RedirectToAction("/Home/Index.cshtml");

		}
	}
}