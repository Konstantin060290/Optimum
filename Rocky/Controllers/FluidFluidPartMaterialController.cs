using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rocky.Data;
using Rocky.Models;
using Rocky.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Controllers
    {
    [Authorize(Roles = WC.AdminRole)]
    public class FluidFluidPartMaterialController : Controller
        {
        
        private readonly ApplicationDbContext _db;

        public FluidFluidPartMaterialController(ApplicationDbContext db)
            {
            _db = db;
            }

        public IActionResult Index()
            {
            IEnumerable<FluidFluidPartMaterial> objList = _db.FluidFluidPartMaterial.Include(u=>u.FluidPartMaterial).Include(u=>u.Fluid);
            return View(objList);
            }

        public IActionResult Create()
            {
            List<SelectListItem> compatibility = new List<SelectListItem>();
            compatibility.Add(new SelectListItem() { Text = "A", Value = "A" });
            compatibility.Add(new SelectListItem() { Text = "B", Value = "B" });
            compatibility.Add(new SelectListItem() { Text = "C", Value = "C" });
            ViewBag.compatibilityVB = compatibility;

            FfpmVM ffpmVM = new FfpmVM()
                {
                FluidFluidPartMaterial = new FluidFluidPartMaterial(),
                FluidSelectList = _db.Fluid.Select(i => new SelectListItem
                    {
                    Text = i.Name,
                    Value = i.Id.ToString()
                    }),
                FluidPartMaterialSelectList = _db.FluidPartMaterial.Select(i => new SelectListItem
                    {
                    Text = i.Name,
                    Value = i.Id.ToString()
                    })
                };
            return View(ffpmVM);       
            }

        //Post-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FfpmVM obj)
            {
            if (ModelState.IsValid)
                {
                _db.Add(obj.FluidFluidPartMaterial);
                _db.SaveChanges();
                return RedirectToAction("Index");
                }
            return View();
            }

        //GET-Edit
        public IActionResult Edit(int? id)
            {
            FfpmVM ffpmVM = new FfpmVM()
                {
                FluidFluidPartMaterial = new FluidFluidPartMaterial(),
                FluidSelectList = _db.Fluid.Select(i => new SelectListItem
                    {
                    Text = i.Name,
                    Value = i.Id.ToString()
                    }),
                FluidPartMaterialSelectList = _db.FluidPartMaterial.Select(i => new SelectListItem
                    {
                    Text = i.Name,
                    Value = i.Id.ToString()
                    })
                };
            ffpmVM.FluidFluidPartMaterial = _db.FluidFluidPartMaterial.Find(id);

            if (ffpmVM.FluidFluidPartMaterial == null)
                {
                return NotFound();
                }
            return View(ffpmVM);
            }

        //Post-Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(FfpmVM obj)
            {
            if (ModelState.IsValid)
                {
                _db.Update(obj.FluidFluidPartMaterial);
                _db.SaveChanges();
                return RedirectToAction("Index");
                }
            return View();
            }

        //GET-Delete
        public IActionResult Delete(int? id)
            {
            FfpmVM ffpmVM = new FfpmVM()
                {
                FluidFluidPartMaterial = new FluidFluidPartMaterial(),
                FluidSelectList = _db.Fluid.Select(i => new SelectListItem
                    {
                    Text = i.Name,
                    Value = i.Id.ToString()
                    }),
                FluidPartMaterialSelectList = _db.FluidPartMaterial.Select(i => new SelectListItem
                    {
                    Text = i.Name,
                    Value = i.Id.ToString()
                    })
                };
            ffpmVM.FluidFluidPartMaterial = _db.FluidFluidPartMaterial.Find(id);

            if (ffpmVM.FluidFluidPartMaterial == null)
                {
                return NotFound();
                }
            return View(ffpmVM);
            }

        //Post-Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
            {
            var obj = _db.FluidFluidPartMaterial.Find(id);
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
