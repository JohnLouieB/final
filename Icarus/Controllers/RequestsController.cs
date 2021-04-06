﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Icarus.Models;

namespace Icarus.Controllers
{
    public class RequestsController : Controller
    {
        private ICARUSDBEntities db = new ICARUSDBEntities();

        [Route("Requests/")]
        // GET: Requests
        public ActionResult Index()
        {
            if (Session["Username"] != null)
            {
                return View(db.tblRequests.ToList());
            }
            else {
                return RedirectToAction("Login", "Login");
            }
        }

        // GET: Requests/Details/5
        public ActionResult Details(int? id)
        {
            if (Session["Username"] != null)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                tblRequest tblRequest = db.tblRequests.Find(id);
                if (tblRequest == null)
                {
                    return HttpNotFound();
                }
                return View(tblRequest);
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        // GET: Requests/Create
        public ActionResult Create()
        {
            if (Session["Username"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        // POST: Requests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDRequest,DateRequest,DateNeeded,RequestedBy,Request,Budget,ApprovedBy,IDRequestStatus,ApproverNotes,DateApproved,RequestorEmail,DateAcc,RequestorNotes")] tblRequest tblRequest)
        {
            if (Session["Username"] != null)
            {
                if (ModelState.IsValid)
                {
                    db.tblRequests.Add(tblRequest);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(tblRequest);
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        // GET: Requests/Edit/5
        public ActionResult Edit(int? id)
        {
            if (Session["Username"] != null)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                tblRequest tblRequest = db.tblRequests.Find(id);
                if (tblRequest == null)
                {
                    return HttpNotFound();
                }
                return View(tblRequest);
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        // POST: Requests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDRequest,DateRequest,DateNeeded,RequestedBy,Request,Budget,ApprovedBy,IDRequestStatus,ApproverNotes,DateApproved,RequestorEmail,DateAcc,RequestorNotes")] tblRequest tblRequest)
        {
            if (Session["Username"] != null)
            {
                if (ModelState.IsValid)
                {
                    db.Entry(tblRequest).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(tblRequest);
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        // GET: Requests/Delete/5
        public ActionResult Delete(int? id)
        {
            if (Session["Username"] != null)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                tblRequest tblRequest = db.tblRequests.Find(id);
                if (tblRequest == null)
                {
                    return HttpNotFound();
                }
                return View(tblRequest);
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        // POST: Requests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            if (Session["Username"] != null)
            {
                tblRequest tblRequest = db.tblRequests.Find(id);
                db.tblRequests.Remove(tblRequest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
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
