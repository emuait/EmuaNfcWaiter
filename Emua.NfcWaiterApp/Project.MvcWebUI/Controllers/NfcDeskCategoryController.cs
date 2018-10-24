using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project.Entities.Concrete;
using Project.Business.Abstract;

namespace Project.MvcWebUI.Controllers
{
    public class NfcDeskCategoryController : Controller
    {
        private dbEmuaNfcContext db = new dbEmuaNfcContext();
		private INfcDeskCategoryBOL _nfcDeskCategoryBol;

		public NfcDeskCategoryController(INfcDeskCategoryBOL nfcDeskCategoryBol)
		{
			_nfcDeskCategoryBol = nfcDeskCategoryBol;
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
			ViewBag.CompanyId = new SelectList(db.NfcCompany, "Id", "Name");
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

			ViewBag.CompanyId = new SelectList(db.NfcCompany, "Id", "Name", nfcDeskCategory.CompanyId);
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
			ViewBag.CompanyId = new SelectList(db.NfcCompany, "Id", "Name", nfcDeskCategory.CompanyId);
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
			ViewBag.CompanyId = new SelectList(db.NfcCompany, "Id", "Name", nfcDeskCategory.CompanyId);
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

		protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
