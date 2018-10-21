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
    public class NfcDeskCategoryController : Controller
    {
        private dbEmuaNfcContext db = new dbEmuaNfcContext();

        // GET: NfcDeskCategory
        public async Task<ActionResult> Index()
        {
            var nfcDeskCategory = db.NfcDeskCategory.Include(n => n.NfcCompany);
            return View(await nfcDeskCategory.ToListAsync());
        }

        // GET: NfcDeskCategory/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NfcDeskCategory nfcDeskCategory = await db.NfcDeskCategory.FindAsync(id);
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
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,OrderNumber,CreatedDate,CompanyId")] NfcDeskCategory nfcDeskCategory)
        {
            if (ModelState.IsValid)
            {
                db.NfcDeskCategory.Add(nfcDeskCategory);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.CompanyId = new SelectList(db.NfcCompany, "Id", "Name", nfcDeskCategory.CompanyId);
            return View(nfcDeskCategory);
        }

        // GET: NfcDeskCategory/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NfcDeskCategory nfcDeskCategory = await db.NfcDeskCategory.FindAsync(id);
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
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,OrderNumber,CreatedDate,CompanyId")] NfcDeskCategory nfcDeskCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nfcDeskCategory).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.CompanyId = new SelectList(db.NfcCompany, "Id", "Name", nfcDeskCategory.CompanyId);
            return View(nfcDeskCategory);
        }

        // GET: NfcDeskCategory/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NfcDeskCategory nfcDeskCategory = await db.NfcDeskCategory.FindAsync(id);
            if (nfcDeskCategory == null)
            {
                return HttpNotFound();
            }
            return View(nfcDeskCategory);
        }

        // POST: NfcDeskCategory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            NfcDeskCategory nfcDeskCategory = await db.NfcDeskCategory.FindAsync(id);
            db.NfcDeskCategory.Remove(nfcDeskCategory);
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
