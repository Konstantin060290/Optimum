using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Rocky.Data;
using Rocky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Controllers
    {
    [Authorize(Roles = WC.AdminRole)]
    public class FluidController : Controller
        {
        
        private readonly ApplicationDbContext _db;

        public FluidController(ApplicationDbContext db)
            {
            _db = db;
            }

        public IActionResult Index()
            {
            IEnumerable<Fluid> objList = _db.Fluid;
            return View(objList);
            }
        //GET-Create
        public IActionResult Create()
            {
            return View();
            }

        //Post-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Fluid obj)
            {
            if (ModelState.IsValid)
                {
                _db.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
                }
            return View();
            }

        //GET-Edit
        public IActionResult Edit(int? id)
            {
            if (id == null || id == 0)
                {
                return NotFound();
                }
            var obj = _db.Fluid.Find(id);
            if (obj == null)
                {
                return NotFound();
                }
            return View(obj);
            }

        //Post-Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Fluid obj)
            {
            if (ModelState.IsValid)
                {
                _db.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
                }
            return View();
            }

        //GET-Delete
        public IActionResult Delete(int? id)
            {
            if (id == null || id == 0)
                {
                return NotFound();
                }
            var obj = _db.Fluid.Find(id);
            if (obj == null)
                {
                return NotFound();
                }
            return View(obj);
            }

        //Post-Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
            {
            var obj = _db.Fluid.Find(id);
            if (obj == null)
                {
                return NotFound();
                }
            _db.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
            }

        }
    }
