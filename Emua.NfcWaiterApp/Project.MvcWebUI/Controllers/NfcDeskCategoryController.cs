using Project.Business.Abstract;
using Project.Entities.Concrete;
using System.Net;
using System.Web.Mvc;

namespace Project.MvcWebUI.Controllers
{
	public class NfcDeskCategoryController : Controller
    {
		private INfcDeskBOL _nfcDeskBol;
		private INfcCompanyBOL _nfcCompanyBol;
		private INfcDeskCategoryBOL _nfcDeskCategoryBol;

		public NfcDeskCategoryController(INfcDeskCategoryBOL nfcDeskCategoryBol, INfcDeskBOL nfcDeskBol, INfcCompanyBOL nfcCompanyBol)
		{
			_nfcDeskCategoryBol = nfcDeskCategoryBol;
			_nfcCompanyBol = nfcCompanyBol;
			_nfcDeskBol = nfcDeskBol;
		}

		// GET: NfcDeskCategory
		public ActionResult Index()
		{
			var nfcDeskCategory = _nfcDeskCategoryBol.GetAll();
			return View(nfcDeskCategory);
		}

		// GET: NfcDeskCategory/Details/5
		public ActionResult Details(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			NfcDeskCategory nfcDeskCategory = _nfcDeskCategoryBol.Get(id);
			if (nfcDeskCategory == null)
			{
				return HttpNotFound();
			}
			return View(nfcDeskCategory);
		}

		// GET: NfcDeskCategory/Create
		public ActionResult Create()
		{
			ViewBag.CompanyId = new SelectList(_nfcCompanyBol.GetAll(), "Id", "Name");
			return View();
		}

		// POST: NfcDeskCategory/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create([Bind(Include = "Id,Name,OrderNumber,CreatedDate,CompanyId")] NfcDeskCategory nfcDeskCategory)
		{
			if (ModelState.IsValid)
			{
				_nfcDeskCategoryBol.Add(nfcDeskCategory);
				return RedirectToAction("Index");
			}

			ViewBag.CompanyId = new SelectList(_nfcCompanyBol.GetAll(), "Id", "Name", nfcDeskCategory.CompanyId);
			return View(nfcDeskCategory);
		}

		// GET: NfcDeskCategory/Edit/5
		public ActionResult Edit(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			NfcDeskCategory nfcDeskCategory = _nfcDeskCategoryBol.Get(id);
			if (nfcDeskCategory == null)
			{
				return HttpNotFound();
			}
			ViewBag.CompanyId = new SelectList(_nfcCompanyBol.GetAll(), "Id", "Name", nfcDeskCategory.CompanyId);
			return View(nfcDeskCategory);
		}

		// POST: NfcDeskCategory/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit([Bind(Include = "Id,Name,OrderNumber,CreatedDate,CompanyId")] NfcDeskCategory nfcDeskCategory)
		{
			if (ModelState.IsValid)
			{
				_nfcDeskCategoryBol.Update(nfcDeskCategory);
				return RedirectToAction("Index");
			}
			ViewBag.CompanyId = new SelectList(_nfcCompanyBol.GetAll(), "Id", "Name", nfcDeskCategory.CompanyId);
			return View(nfcDeskCategory);
		}

		// GET: NfcDeskCategory/Delete/5
		public ActionResult Delete(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			NfcDeskCategory nfcDeskCategory = _nfcDeskCategoryBol.Get(id);
			if (nfcDeskCategory == null)
			{
				return HttpNotFound();
			}
			return View(nfcDeskCategory);
		}

		// POST: NfcDeskCategory/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id)
		{
			NfcDeskCategory nfcDeskCategory = _nfcDeskCategoryBol.Get(id);
			_nfcDeskCategoryBol.Delete(nfcDeskCategory);
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
