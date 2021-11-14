using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models.ViewModels
    {
    public class FfpmVM
        {
        public FluidFluidPartMaterial FluidFluidPartMaterial { get; set; }
        public IEnumerable<SelectListItem> FluidSelectList { get; set; }
        public IEnumerable<SelectListItem> FluidPartMaterialSelectList { get; set; }
        }
    }
