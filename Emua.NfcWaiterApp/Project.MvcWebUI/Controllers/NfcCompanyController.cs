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
    public class NfcCompanyController : Controller
    {
        private dbEmuaNfcContext db = new dbEmuaNfcContext();

        // GET: NfcCompany
        public async Task<ActionResult> Index()
        {
            return View(await db.NfcCompany.ToListAsync());
        }

        // GET: NfcCompany/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NfcCompany nfcCompany = await db.NfcCompany.FindAsync(id);
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
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,LogoUrl,WebSiteUrl,Adress,Mail,Phone,CreatedDate")] NfcCompany nfcCompany)
        {
            if (ModelState.IsValid)
            {
                db.NfcCompany.Add(nfcCompany);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(nfcCompany);
        }

        // GET: NfcCompany/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NfcCompany nfcCompany = await db.NfcCompany.FindAsync(id);
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
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,LogoUrl,WebSiteUrl,Adress,Mail,Phone,CreatedDate")] NfcCompany nfcCompany)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nfcCompany).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(nfcCompany);
        }

        // GET: NfcCompany/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NfcCompany nfcCompany = await db.NfcCompany.FindAsync(id);
            if (nfcCompany == null)
            {
                return HttpNotFound();
            }
            return View(nfcCompany);
        }

        // POST: NfcCompany/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            NfcCompany nfcCompany = await db.NfcCompany.FindAsync(id);
            db.NfcCompany.Remove(nfcCompany);
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
