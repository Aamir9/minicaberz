using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using thechauffeurteam.DAL;
using thechauffeurteam.Models;

namespace thechauffeurteam.Controllers
{
    public class testController : Controller
    {
        private MyContext db = new MyContext();

        // GET: test
        public async Task<ActionResult> Index()
        {
            return View(await db.eclasses.ToListAsync());
        }

        // GET: test/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Eclass eclass = await db.eclasses.FindAsync(id);
            if (eclass == null)
            {
                return HttpNotFound();
            }
            return View(eclass);
        }

        // GET: test/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: test/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,FirstMile,PerMiles")] Eclass eclass)
        {
            if (ModelState.IsValid)
            {
                db.eclasses.Add(eclass);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(eclass);
        }

        // GET: test/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Eclass eclass = await db.eclasses.FindAsync(id);
            if (eclass == null)
            {
                return HttpNotFound();
            }
            return View(eclass);
        }

        // POST: test/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,FirstMile,PerMiles")] Eclass eclass)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eclass).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(eclass);
        }

        // GET: test/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Eclass eclass = await db.eclasses.FindAsync(id);
            if (eclass == null)
            {
                return HttpNotFound();
            }
            return View(eclass);
        }

        // POST: test/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Eclass eclass = await db.eclasses.FindAsync(id);
            db.eclasses.Remove(eclass);
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
