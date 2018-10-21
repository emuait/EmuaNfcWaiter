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

namespace Project.MvcWebUI.Controllers
{
	public class NfcMenuController : Controller
	{
		private dbEmuaNfcContext db = new dbEmuaNfcContext();

		// GET: NfcMenu
		public async Task<ActionResult> Index()
		{
			var nfcMenu = db.NfcMenu.Include(n => n.NfcCompany);
			return View(await nfcMenu.ToListAsync());
		}

		// GET: NfcMenu/Details/5
		public async Task<ActionResult> Details(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			NfcMenu nfcMenu = await db.NfcMenu.FindAsync(id);
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
		public async Task<ActionResult> Create([Bind(Include = "Id,Name,ImageUrl,Url,Title,OrderNumber,Status,CreatedDate,IsAdmin,CompanyId")] NfcMenu nfcMenu)
		{
			if (ModelState.IsValid)
			{
				db.NfcMenu.Add(nfcMenu);
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
			}

			ViewBag.CompanyId = new SelectList(db.NfcCompany, "Id", "Name", nfcMenu.CompanyId);
			return View(nfcMenu);
		}

		// GET: NfcMenu/Edit/5
		public async Task<ActionResult> Edit(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			NfcMenu nfcMenu = await db.NfcMenu.FindAsync(id);
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
		public async Task<ActionResult> Edit([Bind(Include = "Id,Name,ImageUrl,Url,Title,OrderNumber,Status,CreatedDate,IsAdmin,CompanyId")] NfcMenu nfcMenu)
		{
			if (ModelState.IsValid)
			{
				db.Entry(nfcMenu).State = EntityState.Modified;
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
			}
			ViewBag.CompanyId = new SelectList(db.NfcCompany, "Id", "Name", nfcMenu.CompanyId);
			return View(nfcMenu);
		}

		// GET: NfcMenu/Delete/5
		public async Task<ActionResult> Delete(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			NfcMenu nfcMenu = await db.NfcMenu.FindAsync(id);
			if (nfcMenu == null)
			{
				return HttpNotFound();
			}
			return View(nfcMenu);
		}

		// POST: NfcMenu/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> DeleteConfirmed(int id)
		{
			NfcMenu nfcMenu = await db.NfcMenu.FindAsync(id);
			db.NfcMenu.Remove(nfcMenu);
			await db.SaveChangesAsync();
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
