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
    public class NfcCompanyDeskAlarmsController : Controller
    {
        private dbEmuaNfcContext db = new dbEmuaNfcContext();

        // GET: NfcCompanyDeskAlarms
        public async Task<ActionResult> Index()
        {
            var nfcCompanyDeskAlarm = db.NfcCompanyDeskAlarm.Include(n => n.NfcCompany).Include(n => n.NfcDesk);
            return View(await nfcCompanyDeskAlarm.ToListAsync());
        }

        // GET: NfcCompanyDeskAlarms/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NfcCompanyDeskAlarm nfcCompanyDeskAlarm = await db.NfcCompanyDeskAlarm.FindAsync(id);
            if (nfcCompanyDeskAlarm == null)
            {
                return HttpNotFound();
            }
            return View(nfcCompanyDeskAlarm);
        }

        // GET: NfcCompanyDeskAlarms/Create
        public ActionResult Create()
        {
            ViewBag.CompanyId = new SelectList(db.NfcCompany, "Id", "Name");
            ViewBag.DeskId = new SelectList(db.NfcDesk, "Id", "Name");
            return View();
        }

        // POST: NfcCompanyDeskAlarms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,AlarmTypeName,CreatedDate,DeskId,CompanyId")] NfcCompanyDeskAlarm nfcCompanyDeskAlarm)
        {
            if (ModelState.IsValid)
            {
                db.NfcCompanyDeskAlarm.Add(nfcCompanyDeskAlarm);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.CompanyId = new SelectList(db.NfcCompany, "Id", "Name", nfcCompanyDeskAlarm.CompanyId);
            ViewBag.DeskId = new SelectList(db.NfcDesk, "Id", "Name", nfcCompanyDeskAlarm.DeskId);
            return View(nfcCompanyDeskAlarm);
        }

        // GET: NfcCompanyDeskAlarms/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NfcCompanyDeskAlarm nfcCompanyDeskAlarm = await db.NfcCompanyDeskAlarm.FindAsync(id);
            if (nfcCompanyDeskAlarm == null)
            {
                return HttpNotFound();
            }
            ViewBag.CompanyId = new SelectList(db.NfcCompany, "Id", "Name", nfcCompanyDeskAlarm.CompanyId);
            ViewBag.DeskId = new SelectList(db.NfcDesk, "Id", "Name", nfcCompanyDeskAlarm.DeskId);
            return View(nfcCompanyDeskAlarm);
        }

        // POST: NfcCompanyDeskAlarms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,AlarmTypeName,CreatedDate,DeskId,CompanyId")] NfcCompanyDeskAlarm nfcCompanyDeskAlarm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nfcCompanyDeskAlarm).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.CompanyId = new SelectList(db.NfcCompany, "Id", "Name", nfcCompanyDeskAlarm.CompanyId);
            ViewBag.DeskId = new SelectList(db.NfcDesk, "Id", "Name", nfcCompanyDeskAlarm.DeskId);
            return View(nfcCompanyDeskAlarm);
        }

        // GET: NfcCompanyDeskAlarms/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NfcCompanyDeskAlarm nfcCompanyDeskAlarm = await db.NfcCompanyDeskAlarm.FindAsync(id);
            if (nfcCompanyDeskAlarm == null)
            {
                return HttpNotFound();
            }
            return View(nfcCompanyDeskAlarm);
        }

        // POST: NfcCompanyDeskAlarms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            NfcCompanyDeskAlarm nfcCompanyDeskAlarm = await db.NfcCompanyDeskAlarm.FindAsync(id);
            db.NfcCompanyDeskAlarm.Remove(nfcCompanyDeskAlarm);
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
