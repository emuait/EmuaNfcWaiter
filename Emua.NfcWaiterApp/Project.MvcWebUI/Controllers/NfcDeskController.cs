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
    public class NfcDeskController : Controller
    {
        private dbEmuaNfcContext db = new dbEmuaNfcContext();

        // GET: NfcDesk
        public async Task<ActionResult> Index()
        {
            var nfcDesk = db.NfcDesk.Include(n => n.NfcCompany).Include(n => n.NfcDeskCategory);
            return View(await nfcDesk.ToListAsync());
        }

        // GET: NfcDesk/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NfcDesk nfcDesk = await db.NfcDesk.FindAsync(id);
            if (nfcDesk == null)
            {
                return HttpNotFound();
            }
            return View(nfcDesk);
        }

        // GET: NfcDesk/Create
        public ActionResult Create()
        {
            ViewBag.CompanyId = new SelectList(db.NfcCompany, "Id", "Name");
            ViewBag.DeskCategoryId = new SelectList(db.NfcDeskCategory, "Id", "Name");
            return View();
        }

        // POST: NfcDesk/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,CreatedDate,DeskCategoryId,CompanyId")] NfcDesk nfcDesk)
        {
            if (ModelState.IsValid)
            {
                db.NfcDesk.Add(nfcDesk);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.CompanyId = new SelectList(db.NfcCompany, "Id", "Name", nfcDesk.CompanyId);
            ViewBag.DeskCategoryId = new SelectList(db.NfcDeskCategory, "Id", "Name", nfcDesk.DeskCategoryId);
            return View(nfcDesk);
        }

        // GET: NfcDesk/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NfcDesk nfcDesk = await db.NfcDesk.FindAsync(id);
            if (nfcDesk == null)
            {
                return HttpNotFound();
            }
            ViewBag.CompanyId = new SelectList(db.NfcCompany, "Id", "Name", nfcDesk.CompanyId);
            ViewBag.DeskCategoryId = new SelectList(db.NfcDeskCategory, "Id", "Name", nfcDesk.DeskCategoryId);
            return View(nfcDesk);
        }

        // POST: NfcDesk/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,CreatedDate,DeskCategoryId,CompanyId")] NfcDesk nfcDesk)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nfcDesk).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.CompanyId = new SelectList(db.NfcCompany, "Id", "Name", nfcDesk.CompanyId);
            ViewBag.DeskCategoryId = new SelectList(db.NfcDeskCategory, "Id", "Name", nfcDesk.DeskCategoryId);
            return View(nfcDesk);
        }

        // GET: NfcDesk/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NfcDesk nfcDesk = await db.NfcDesk.FindAsync(id);
            if (nfcDesk == null)
            {
                return HttpNotFound();
            }
            return View(nfcDesk);
        }

        // POST: NfcDesk/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            NfcDesk nfcDesk = await db.NfcDesk.FindAsync(id);
            db.NfcDesk.Remove(nfcDesk);
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
