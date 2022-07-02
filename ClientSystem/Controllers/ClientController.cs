using ClientSystem.Data;
using ClientSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientSystem.Controllers
{
    public class ClientController : Controller
    {

        private readonly ApplicationDBContext _db;

        public ClientController(ApplicationDBContext db)
        {
            _db = db;
        }

        // GET: ClientController
        public ActionResult Index()
        {
            IEnumerable<Client> objList = _db.Clients;
            return View(objList);
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Client obj)
        {
            try
            {
                _db.Clients.Add(obj);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null || id == 0)
                return NotFound();

            var obj = _db.Clients.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        // POST: ClientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditPost(Client obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _db.Clients.Update(obj);
                    _db.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                return View(obj);
            }
            catch
            {
                return View(obj);
            }
        }

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            if (id==null || id==0)
                return NotFound();

            var obj = _db.Clients.Find(id);
            if (obj==null)
            {
                return NotFound();
            }

            return View(obj);
        }

        // POST: ClientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int? id)
        {
            try
            {
                var obj = _db.Clients.Find(id);
                
                if (obj == null)
                    return NotFound();

                _db.Clients.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
