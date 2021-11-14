using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models.ViewModels
    {
    public class RequirementsVM
        {
        public Product Product { get; set; }
        public Requirements Requirements { get; set; }
        public Fluid Fluid { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<SelectListItem> FluidSelectList { get; set; }

        }
    }
