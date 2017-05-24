using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class MovesController : Controller
    {
        private WebapplicationDbContext db = new WebapplicationDbContext();

        // GET: Moves
        public ActionResult Index()
        {
            return View(db.Moves.ToList());
        }
        
        public ActionResult SearchMove(string title)
        {
            
            if (!String.IsNullOrEmpty(title))
            {
               var moves= from m in db.Moves
                            where m.Title.Contains(title)
                            select m;
                return View("Index", moves);
            }
            return View("Index");
        }

        // GET: Moves/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Move move = db.Moves.Find(id);
            if (move == null)
            {
                return HttpNotFound();
            }
            return View(move);
        }

        // GET: Moves/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Moves/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,ReleaseDate,Genre,Price")] Move move)
        {
            if (ModelState.IsValid)
            {
                db.Moves.Add(move);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(move);
        }

        // GET: Moves/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Move move = db.Moves.Find(id);
            if (move == null)
            {
                return HttpNotFound();
            }
            return View(move);
        }

        // POST: Moves/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,ReleaseDate,Genre,Price")] Move move)
        {
            if (ModelState.IsValid)
            {
                db.Entry(move).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(move);
        }

        // GET: Moves/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Move move = db.Moves.Find(id);
            if (move == null)
            {
                return HttpNotFound();
            }
            return View(move);
        }

        // POST: Moves/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Move move = db.Moves.Find(id);
            db.Moves.Remove(move);
            db.SaveChanges();
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
