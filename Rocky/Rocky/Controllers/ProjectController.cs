using Microsoft.AspNetCore.Mvc;
using Rocky.Data;
using Rocky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Controllers
    {
    public class ProjectController : Controller
        {
        private readonly ApplicationDbContext _db;

        public ProjectController(ApplicationDbContext db)
            {
            _db = db;
            }

        public IActionResult Index()
            {
            IEnumerable<Project> objList = _db.Project;
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
        public IActionResult Create (Project obj)
            {
            _db.Add(obj);
            _db.SaveChanges();
            return View();
            }

        }
    }
