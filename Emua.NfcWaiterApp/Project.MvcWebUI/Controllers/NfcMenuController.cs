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
	public class NfcMenuController : Controller
	{
		private dbEmuaNfcContext db = new dbEmuaNfcContext();
		private INfcMenuBOL _nfcMenuBol;

		public NfcMenuController(INfcMenuBOL nfcMenuBol)
		{
			_nfcMenuBol = nfcMenuBol;
		}
		// GET: NfcMenu
		public ActionResult Index()
		{
			var nfcMenu = _nfcMenuBol.GetAll();
			return View(nfcMenu);
		}

		// GET: NfcMenu/Details/5
		public ActionResult Details(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			NfcMenu nfcMenu = _nfcMenuBol.Get(id);
			if (nfcMenu == null)
			{
				return HttpNotFound();
			}
			return View(nfcMenu);
		}

		// GET: NfcMenu/Create
		public ActionResult Create()
		{
			ViewBag.CompanyId = new SelectList(db.NfcCompany, "Id", "Name");
			return View();
		}

		// POST: NfcMenu/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create([Bind(Include = "Id,Name,ImageUrl,Url,Title,OrderNumber,Status,CreatedDate,IsAdmin,CompanyId")] NfcMenu nfcMenu)
		{
			if (ModelState.IsValid)
			{
				_nfcMenuBol.Add(nfcMenu);
				return RedirectToAction("Index");
			}

			ViewBag.CompanyId = new SelectList(db.NfcCompany, "Id", "Name", nfcMenu.CompanyId);
			return View(nfcMenu);
		}

		// GET: NfcMenu/Edit/5
		public ActionResult Edit(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			NfcMenu nfcMenu = _nfcMenuBol.Get(id);
			if (nfcMenu == null)
			{
				return HttpNotFound();
			}
			ViewBag.CompanyId = new SelectList(db.NfcCompany, "Id", "Name", nfcMenu.CompanyId);
			return View(nfcMenu);
		}

		// POST: NfcMenu/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit([Bind(Include = "Id,Name,ImageUrl,Url,Title,OrderNumber,Status,CreatedDate,IsAdmin,CompanyId")] NfcMenu nfcMenu)
		{
			if (ModelState.IsValid)
			{
				_nfcMenuBol.Update(nfcMenu);
				return RedirectToAction("Index");
			}
			ViewBag.CompanyId = new SelectList(db.NfcCompany, "Id", "Name", nfcMenu.CompanyId);
			return View(nfcMenu);
		}

		// GET: NfcMenu/Delete/5
		public ActionResult Delete(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			NfcMenu nfcMenu = _nfcMenuBol.Get(id);
			if (nfcMenu == null)
			{
				return HttpNotFound();
			}
			return View(nfcMenu);
		}

		// POST: NfcMenu/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id)
		{
			NfcMenu nfcMenu = _nfcMenuBol.Get(id);
			_nfcMenuBol.Delete(nfcMenu);
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
