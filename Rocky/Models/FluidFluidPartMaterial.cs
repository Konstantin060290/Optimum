using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
    {
    public class FluidFluidPartMaterial
        {
        [Key] public int Id { get; set; }
        [Display(Name = "Перекачиваемая жидкость")] public int FluidId { get; set; }
        [ForeignKey("FluidId")] public virtual Fluid Fluid { get; set; }

        [Display(Name = "Материал проточной части")] public int FluidPartMaterialId { get; set; }
        [ForeignKey("FluidPartMaterialId")] public virtual FluidPartMaterial FluidPartMaterial { get; set; }

        [Required][Display(Name = "Скорость коррозии материала в жидоксти, мм/год")] public decimal CorrVelForFluid { get; set; }
        [Required][Display(Name = "Применимость материала в жидкости")] public string Applicability { get; set; }

        }
    }
