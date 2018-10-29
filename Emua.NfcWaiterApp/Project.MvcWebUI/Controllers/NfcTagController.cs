﻿using Project.Business.Abstract;
using Project.Entities.Concrete;
using System.Net;
using System.Web.Mvc;

namespace Project.MvcWebUI.Controllers
{
	public class NfcTagController : Controller
    {
		private INfcDeskBOL _nfcDeskBol;
		private INfcCompanyBOL _nfcCompanyBol;
		private INfcTagBOL _nfcTagBol;

		public NfcTagController(INfcTagBOL nfcTagBol, INfcDeskBOL nfcDeskBol, INfcCompanyBOL nfcCompanyBol)
		{
			_nfcCompanyBol = nfcCompanyBol;
			_nfcDeskBol = nfcDeskBol;
			_nfcTagBol = nfcTagBol;
		}
		// GET: NfcTag
		public ActionResult Index()
		{
			var nfcTag = _nfcTagBol.GetAll();
			return View(nfcTag);
		}

		// GET: NfcTag/Details/5
		public ActionResult Details(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			NfcTag nfcTag = _nfcTagBol.Get(id);
			if (nfcTag == null)
			{
				return HttpNotFound();
			}
			return View(nfcTag);
		}

		// GET: NfcTag/Create
		public ActionResult Create()
		{
			ViewBag.CompanyId = new SelectList(_nfcCompanyBol.GetAll(), "Id", "Name");
			ViewBag.DeskId = new SelectList(_nfcDeskBol.GetAll(), "Id", "Name");
			return View();
		}

		// POST: NfcTag/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create([Bind(Include = "Id,Name,Code,CreatedDate,CompanyId,DeskId")] NfcTag nfcTag)
		{
			if (ModelState.IsValid)
			{
				_nfcTagBol.Add(nfcTag);
				return RedirectToAction("Index");
			}

			ViewBag.CompanyId = new SelectList(_nfcCompanyBol.GetAll(), "Id", "Name", nfcTag.CompanyId);
			ViewBag.DeskId = new SelectList(_nfcDeskBol.GetAll(), "Id", "Name", nfcTag.DeskId);
			return View(nfcTag);
		}

		// GET: NfcTag/Edit/5
		public ActionResult Edit(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			NfcTag nfcTag = _nfcTagBol.Get(id);
			if (nfcTag == null)
			{
				return HttpNotFound();
			}
			ViewBag.CompanyId = new SelectList(_nfcCompanyBol.GetAll(), "Id", "Name", nfcTag.CompanyId);
			ViewBag.DeskId = new SelectList(_nfcDeskBol.GetAll(), "Id", "Name", nfcTag.DeskId);
			return View(nfcTag);
		}

		// POST: NfcTag/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit([Bind(Include = "Id,Name,Code,CreatedDate,CompanyId,DeskId")] NfcTag nfcTag)
		{
			if (ModelState.IsValid)
			{
				_nfcTagBol.Update(nfcTag);
				return RedirectToAction("Index");
			}
			ViewBag.CompanyId = new SelectList(_nfcCompanyBol.GetAll(), "Id", "Name", nfcTag.CompanyId);
			ViewBag.DeskId = new SelectList(_nfcDeskBol.GetAll(), "Id", "Name", nfcTag.DeskId);
			return View(nfcTag);
		}

		// GET: NfcTag/Delete/5
		public ActionResult Delete(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			NfcTag nfcTag = _nfcTagBol.Get(id);
			if (nfcTag == null)
			{
				return HttpNotFound();
			}
			return View(nfcTag);
		}

		// POST: NfcTag/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id)
		{
			NfcTag nfcTag = _nfcTagBol.Get(id);
			_nfcTagBol.Delete(nfcTag);
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
