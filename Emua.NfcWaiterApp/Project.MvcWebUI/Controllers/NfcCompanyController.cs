using Project.Business.Abstract;
using Project.Entities.Concrete;
using System.Net;
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
		// GET: NfcCompany
		public ActionResult Index()
		{
			return View(_nfcCompanyBol.GetAll());
		}

		// GET: NfcCompany/Details/5
		public ActionResult Details(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			NfcCompany nfcCompany = _nfcCompanyBol.Get(id);
			if (nfcCompany == null)
			{
				return HttpNotFound();
			}
			return View(nfcCompany);
		}

		// GET: NfcCompany/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: NfcCompany/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create([Bind(Include = "Id,Name,LogoUrl,WebSiteUrl,Adress,Mail,Phone,CreatedDate")] NfcCompany nfcCompany)
		{
			if (ModelState.IsValid)
			{
				_nfcCompanyBol.Add(nfcCompany);
				return RedirectToAction("Index");
			}

			return View(nfcCompany);
		}

		// GET: NfcCompany/Edit/5
		public ActionResult Edit(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			NfcCompany nfcCompany = _nfcCompanyBol.Get(id);
			if (nfcCompany == null)
			{
				return HttpNotFound();
			}
			return View(nfcCompany);
		}

		// POST: NfcCompany/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit([Bind(Include = "Id,Name,LogoUrl,WebSiteUrl,Adress,Mail,Phone,CreatedDate")] NfcCompany nfcCompany)
		{
			if (ModelState.IsValid)
			{
				_nfcCompanyBol.Update(nfcCompany);
				return RedirectToAction("Index");
			}
			return View(nfcCompany);
		}

		// GET: NfcCompany/Delete/5
		public ActionResult Delete(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			NfcCompany nfcCompany = _nfcCompanyBol.Get(id);
			if (nfcCompany == null)
			{
				return HttpNotFound();
			}
			return View(nfcCompany);
		}

		// POST: NfcCompany/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id)
		{
			NfcCompany nfcCompany = _nfcCompanyBol.Get(id);
			_nfcCompanyBol.Delete(nfcCompany);
			return RedirectToAction("Index");
		}

		//protected override void Dispose(bool disposing)
  //      {
  //          if (disposing)
  //          {
  //              db.Dispose();
  //          }
  //          base.Dispose(disposing);
  //      }
    }
}
