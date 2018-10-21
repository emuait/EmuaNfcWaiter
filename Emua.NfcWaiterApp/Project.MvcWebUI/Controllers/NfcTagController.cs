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
    public class NfcTagController : Controller
    {
        private dbEmuaNfcContext db = new dbEmuaNfcContext();

        // GET: NfcTag
        public async Task<ActionResult> Index()
        {
            var nfcTag = db.NfcTag.Include(n => n.NfcCompany).Include(n => n.NfcDesk);
            return View(await nfcTag.ToListAsync());
        }

        // GET: NfcTag/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NfcTag nfcTag = await db.NfcTag.FindAsync(id);
            if (nfcTag == null)
            {
                return HttpNotFound();
            }
            return View(nfcTag);
        }

        // GET: NfcTag/Create
        public ActionResult Create()
        {
            ViewBag.CompanyId = new SelectList(db.NfcCompany, "Id", "Name");
            ViewBag.DeskId = new SelectList(db.NfcDesk, "Id", "Name");
            return View();
        }

        // POST: NfcTag/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,Code,CreatedDate,CompanyId,DeskId")] NfcTag nfcTag)
        {
            if (ModelState.IsValid)
            {
                db.NfcTag.Add(nfcTag);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.CompanyId = new SelectList(db.NfcCompany, "Id", "Name", nfcTag.CompanyId);
            ViewBag.DeskId = new SelectList(db.NfcDesk, "Id", "Name", nfcTag.DeskId);
            return View(nfcTag);
        }

        // GET: NfcTag/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NfcTag nfcTag = await db.NfcTag.FindAsync(id);
            if (nfcTag == null)
            {
                return HttpNotFound();
            }
            ViewBag.CompanyId = new SelectList(db.NfcCompany, "Id", "Name", nfcTag.CompanyId);
            ViewBag.DeskId = new SelectList(db.NfcDesk, "Id", "Name", nfcTag.DeskId);
            return View(nfcTag);
        }

        // POST: NfcTag/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,Code,CreatedDate,CompanyId,DeskId")] NfcTag nfcTag)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nfcTag).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.CompanyId = new SelectList(db.NfcCompany, "Id", "Name", nfcTag.CompanyId);
            ViewBag.DeskId = new SelectList(db.NfcDesk, "Id", "Name", nfcTag.DeskId);
            return View(nfcTag);
        }

        // GET: NfcTag/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NfcTag nfcTag = await db.NfcTag.FindAsync(id);
            if (nfcTag == null)
            {
                return HttpNotFound();
            }
            return View(nfcTag);
        }

        // POST: NfcTag/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            NfcTag nfcTag = await db.NfcTag.FindAsync(id);
            db.NfcTag.Remove(nfcTag);
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
