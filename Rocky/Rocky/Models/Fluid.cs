using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
    {
    public class Fluid
        {
        [Key] public int Id { get; set; }
        [Required] [Display(Name = "Наименование жидкости (и ее температура)")] public string Name { get; set; }

        [Required] [Display(Name = "Температура, °С")] public double Temperature { get; set; }
        [Required] [Display(Name = "Плотность при данной температуре, кг/м3")] public decimal Density { get; set; }
        [Column(TypeName = "decimal(16,6)")] [Required] [Display(Name = "Кинематическая вязкость при данной температуре, сСт")] public decimal Kinematic_Viscosity { get; set; }
        [Required] [Display(Name = "Давление насыщенного пара при данной температуре, кПа")] public decimal Vapor_Pressure { get; set; }
        [Required] [Display(Name = "Значение водородного показателя PH при 25°С")] public float PH { get; set; }

        }
    }
