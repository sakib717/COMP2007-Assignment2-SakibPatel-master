using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using COMP2007_Assignment2_SakibPatel.Models;

namespace COMP2007_Assignment2_SakibPatel.Controllers
{
    [Authorize]
    public class DescriptionsController : Controller
    {
        private PatelBistroContext db = new PatelBistroContext();

        // GET: Descriptions
        [AllowAnonymous]
        public async Task<ActionResult> Index()
        {
            return View(await db.Descriptions.ToListAsync());
        }

        // GET: Descriptions/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Description description = await db.Descriptions.FindAsync(id);
            if (description == null)
            {
                return HttpNotFound();
            }
            return View(description);
        }

        // GET: Descriptions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Descriptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "DescriptionID,FoodTitle,Price")] Description description)
        {
            if (ModelState.IsValid)
            {
                db.Descriptions.Add(description);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(description);
        }

        // GET: Descriptions/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Description description = await db.Descriptions.FindAsync(id);
            if (description == null)
            {
                return HttpNotFound();
            }
            return View(description);
        }

        // POST: Descriptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "DescriptionID,FoodTitle,Price")] Description description)
        {
            if (ModelState.IsValid)
            {
                db.Entry(description).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(description);
        }

        // GET: Descriptions/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Description description = await db.Descriptions.FindAsync(id);
            if (description == null)
            {
                return HttpNotFound();
            }
            return View(description);
        }

        // POST: Descriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Description description = await db.Descriptions.FindAsync(id);
            db.Descriptions.Remove(description);
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
