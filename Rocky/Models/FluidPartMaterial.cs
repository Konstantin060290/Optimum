using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
    {
    public class FluidPartMaterial
        {
        [Key] public int Id { get; set; }
        [Required] [Display(Name = "Наименование материала проточной части")] public string Name { get; set; }
        [Required] [Display(Name = "Условное обозначение по ТУ 3632-003-46919837-2007")] public string CodeName { get; set; }

        }
    }
