using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class MoveTypesController : Controller
    {
        private WebapplicationDbContext db = new WebapplicationDbContext();

        // GET: MoveTypes
        public async Task<ActionResult> Index()
        {
            return View(await db.MoveTypes.ToListAsync());
        }

        // GET: MoveTypes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MoveType moveType = await db.MoveTypes.FindAsync(id);
            if (moveType == null)
            {
                return HttpNotFound();
            }
            return View(moveType);
        }

        // GET: MoveTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MoveTypes/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "TypeId,TypeName")] MoveType moveType)
        {
            if (ModelState.IsValid)
            {
                db.MoveTypes.Add(moveType);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(moveType);
        }

        // GET: MoveTypes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MoveType moveType = await db.MoveTypes.FindAsync(id);
            if (moveType == null)
            {
                return HttpNotFound();
            }
            return View(moveType);
        }

        // POST: MoveTypes/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "TypeId,TypeName")] MoveType moveType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(moveType).State = System.Data.Entity.EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(moveType);
        }

        // GET: MoveTypes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MoveType moveType = await db.MoveTypes.FindAsync(id);
            if (moveType == null)
            {
                return HttpNotFound();
            }
            return View(moveType);
        }

        // POST: MoveTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            MoveType moveType = await db.MoveTypes.FindAsync(id);
            db.MoveTypes.Remove(moveType);
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
