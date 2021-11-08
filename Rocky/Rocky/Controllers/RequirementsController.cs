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
    public class RequirementsController : Controller
        {
        private readonly ApplicationDbContext _db;
        public RequirementsVM rvm { get; set; }
        IEnumerable<Product> ProductsForController { get; set; }
        public RequirementsController(ApplicationDbContext db)
            {
            _db = db;
            }
    public ActionResult Index (RequirementsVM obj)
            {
            List<SelectListItem> placementList = new List<SelectListItem>();
            placementList.Add(new SelectListItem() { Text = "У1", Value = "У1" });
            placementList.Add(new SelectListItem() { Text = "У2", Value = "У2" });
            placementList.Add(new SelectListItem() { Text = "У3", Value = "У3" });
            placementList.Add(new SelectListItem() { Text = "У4", Value = "У4" });
            placementList.Add(new SelectListItem() { Text = "УХЛ1", Value = "УХЛ1" });
            placementList.Add(new SelectListItem() { Text = "УХЛ2", Value = "УХЛ2" });
            placementList.Add(new SelectListItem() { Text = "УХЛ3", Value = "УХЛ3" });
            placementList.Add(new SelectListItem() { Text = "УХЛ4", Value = "УХЛ4" });
            placementList.Add(new SelectListItem() { Text = "ХЛ1", Value = "ХЛ1" });
            placementList.Add(new SelectListItem() { Text = "ХЛ2", Value = "ХЛ2" });
            placementList.Add(new SelectListItem() { Text = "ХЛ3", Value = "ХЛ3" });
            placementList.Add(new SelectListItem() { Text = "ХЛ4", Value = "ХЛ4" });
            placementList.Add(new SelectListItem() { Text = "М1", Value = "М1" });
            placementList.Add(new SelectListItem() { Text = "М2", Value = "М2" });
            placementList.Add(new SelectListItem() { Text = "М3", Value = "М3" });
            placementList.Add(new SelectListItem() { Text = "М4", Value = "М4" });
            placementList.Add(new SelectListItem() { Text = "Т1", Value = "Т1" });
            placementList.Add(new SelectListItem() { Text = "Т2", Value = "Т2" });
            placementList.Add(new SelectListItem() { Text = "Т3", Value = "Т3" });
            placementList.Add(new SelectListItem() { Text = "Т4", Value = "Т4" });
            ViewBag.placementListVB = placementList;

            if (obj.Requirements!=null)
                {
                ProductsForController = _db.Product.Include(u => u.Category).Include(u => u.ApplicationType).Include(u => u.FluidPartMaterial)
                    .Where(x => obj.Requirements.QapacityNeed <= x.Qapacity & obj.Requirements.QapacityNeed > 0.1 * x.Qapacity || x.Qapacity == 0)
                    .Where(x => obj.Requirements.P2Need <= x.P2max || obj.Requirements.P2Need <= x.P2PGA)
                    .Where(x => x.minTemp <= _db.Fluid.Find(obj.Requirements.FluidId).Temperature & x.maxTemp >= _db.Fluid.Find(obj.Requirements.FluidId).Temperature)
                    .Where(x => obj.Requirements.NPIPA <= x.P1 & obj.Requirements.NPIPA > x.NPIPR);
                if (obj.Requirements.FluidId == 0 & obj.Requirements.P2Need == 0 & obj.Requirements.NPIPA == 0 & obj.Requirements.QapacityNeed == 0)
                    {
                    ProductsForController = _db.Product.Include(u => u.Category).Include(u => u.ApplicationType).Include(u => u.FluidPartMaterial);                    
                    }
                if (obj.Requirements.FluidId!=0 & obj.Requirements.P2Need==0 & obj.Requirements.NPIPA==0 & obj.Requirements.QapacityNeed==0)
                    {
                    ProductsForController = _db.Product.Include(u => u.Category).Include(u => u.ApplicationType).Include(u => u.FluidPartMaterial)
                    .Where(x => x.minTemp <= _db.Fluid.Find(obj.Requirements.FluidId).Temperature & x.maxTemp >= _db.Fluid.Find(obj.Requirements.FluidId).Temperature);
                    }
                if (obj.Requirements.QapacityNeed!= 0 & obj.Requirements.FluidId == 0 & obj.Requirements.P2Need == 0 & obj.Requirements.NPIPA == 0)
                    {
                    ProductsForController = _db.Product.Include(u => u.Category).Include(u => u.ApplicationType).Include(u => u.FluidPartMaterial)
                    .Where(x => obj.Requirements.QapacityNeed <= x.Qapacity & obj.Requirements.QapacityNeed > 0.1 * x.Qapacity);
                    }
                if (obj.Requirements.P2Need != 0 & obj.Requirements.FluidId == 0 & obj.Requirements.QapacityNeed == 0 & obj.Requirements.NPIPA == 0)
                    {
                    ProductsForController = _db.Product.Include(u => u.Category).Include(u => u.ApplicationType).Include(u => u.FluidPartMaterial)
                    .Where(x => obj.Requirements.P2Need <= x.P2max || obj.Requirements.P2Need <= x.P2PGA);
                    }
                RequirementsVM requirementsVM = new RequirementsVM()
                    {
                    Requirements = new Requirements()
                        {
                        FluidId = obj.Requirements.FluidId,
                        QapacityNeed = obj.Requirements.QapacityNeed,
                        P2Need = obj.Requirements.P2Need
                        },
                    FluidSelectList = _db.Fluid.Select(i => new SelectListItem
                        {
                        Text = i.Name,
                        Value = i.Id.ToString()
                        }),
                    Products = ProductsForController
                    };
                rvm = requirementsVM;
                }
            else
                {
                RequirementsVM requirementsVM = new RequirementsVM()
                    {
                    Requirements = new Requirements()
                        {
                        },
                    FluidSelectList = _db.Fluid.Select(i => new SelectListItem
                        {
                        Text = i.Name,
                        Value = i.Id.ToString()
                        }),
                    Products = _db.Product.Include(u => u.Category).Include(u => u.ApplicationType).Include(u => u.FluidPartMaterial)
                    };
                rvm = requirementsVM;
                }
            return View(rvm);
            }

        }

    }
     