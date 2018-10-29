using Project.Business.Abstract;
using Project.Entities.Concrete;
using System.Net;
using System.Web.Mvc;

namespace Project.MvcWebUI.Controllers
{
	public class NfcCompanyDeskAlarmsController : Controller
    {
		private INfcCompanyDeskAlarmBOL _nfcCompanyDeskAlarmBol;
		private INfcDeskBOL _nfcDeskBol;
		private INfcCompanyBOL _nfcCompanyBol;

		public NfcCompanyDeskAlarmsController(INfcCompanyDeskAlarmBOL nfcCompanyDeskAlarmBol, INfcDeskBOL nfcDeskBol, INfcCompanyBOL nfcCompanyBol)
		{
			_nfcCompanyDeskAlarmBol = nfcCompanyDeskAlarmBol;
			_nfcCompanyBol = nfcCompanyBol;
			_nfcDeskBol = nfcDeskBol;
		}

		public ActionResult Index()
		{
			var nfcCompanyDeskAlarm = _nfcCompanyDeskAlarmBol.GetAll();
			return View(nfcCompanyDeskAlarm);
		}

		// GET: NfcCompanyDeskAlarms/Details/5
		public ActionResult Details(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			NfcCompanyDeskAlarm nfcCompanyDeskAlarm = _nfcCompanyDeskAlarmBol.Get(id);
			if (nfcCompanyDeskAlarm == null)
			{
				return HttpNotFound();
			}
			return View(nfcCompanyDeskAlarm);
		}

		// GET: NfcCompanyDeskAlarms/Create
		public ActionResult Create()
		{
			ViewBag.CompanyId = new SelectList(_nfcCompanyBol.GetAll(), "Id", "Name");
			ViewBag.DeskId = new SelectList(_nfcDeskBol.GetAll(), "Id", "Name");
			return View();
		}

		// POST: NfcCompanyDeskAlarms/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create([Bind(Include = "Id,AlarmTypeName,CreatedDate,DeskId,CompanyId")] NfcCompanyDeskAlarm nfcCompanyDeskAlarm)
		{
			if (ModelState.IsValid)
			{
				_nfcCompanyDeskAlarmBol.Add(nfcCompanyDeskAlarm);
				return RedirectToAction("Index");
			}

			ViewBag.CompanyId = new SelectList(_nfcCompanyBol.GetAll(), "Id", "Name", nfcCompanyDeskAlarm.CompanyId);
			ViewBag.DeskId = new SelectList(_nfcDeskBol.GetAll(), "Id", "Name", nfcCompanyDeskAlarm.DeskId);
			return View(nfcCompanyDeskAlarm);
		}

		// GET: NfcCompanyDeskAlarms/Edit/5
		public ActionResult Edit(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			NfcCompanyDeskAlarm nfcCompanyDeskAlarm = _nfcCompanyDeskAlarmBol.Get(id);
			if (nfcCompanyDeskAlarm == null)
			{
				return HttpNotFound();
			}
			ViewBag.CompanyId = new SelectList(_nfcCompanyBol.GetAll(), "Id", "Name", nfcCompanyDeskAlarm.CompanyId);
			ViewBag.DeskId = new SelectList(_nfcDeskBol.GetAll(), "Id", "Name", nfcCompanyDeskAlarm.DeskId);
			return View(nfcCompanyDeskAlarm);
		}

		// POST: NfcCompanyDeskAlarms/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit([Bind(Include = "Id,AlarmTypeName,CreatedDate,DeskId,CompanyId")] NfcCompanyDeskAlarm nfcCompanyDeskAlarm)
		{
			if (ModelState.IsValid)
			{
				_nfcCompanyDeskAlarmBol.Update(nfcCompanyDeskAlarm);
				return RedirectToAction("Index");
			}
			ViewBag.CompanyId = new SelectList(_nfcCompanyBol.GetAll(), "Id", "Name", nfcCompanyDeskAlarm.CompanyId);
			ViewBag.DeskId = new SelectList(_nfcDeskBol.GetAll(), "Id", "Name", nfcCompanyDeskAlarm.DeskId);
			return View(nfcCompanyDeskAlarm);
		}

		// GET: NfcCompanyDeskAlarms/Delete/5
		public ActionResult Delete(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			NfcCompanyDeskAlarm nfcCompanyDeskAlarm = _nfcCompanyDeskAlarmBol.Get(id);
			if (nfcCompanyDeskAlarm == null)
			{
				return HttpNotFound();
			}
			return View(nfcCompanyDeskAlarm);
		}

		// POST: NfcCompanyDeskAlarms/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id)
		{
			NfcCompanyDeskAlarm nfcCompanyDeskAlarm = _nfcCompanyDeskAlarmBol.Get(id);
			_nfcCompanyDeskAlarmBol.Delete(nfcCompanyDeskAlarm);
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
