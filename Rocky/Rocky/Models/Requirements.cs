using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
    {
    public class Requirements
        {
        [Key] public int Id { get; set; }
        [Required] [Display(Name = "Температура перекачиваемой жидкости, °С")] public double FluidTemperature { get; set; }
        [Required] [Display(Name = "Требуемая подача, л/ч")] public double QapacityNeed { get; set; }
        [Required] [Display(Name = "Требуемое давление на выходе, кгс/см2 (изб.)")] public double P2Need { get; set; }
        [Required] [Display(Name = "Имеющееся давление на входе, кгс/см2 (абс.)")] public double NPIPA { get; set; }
        [Required] [Display(Name = "Температура окружающей среды, °С")] public double TemperatureOfAir { get; set; }
        [Required] [Display(Name = "Категория размещения по ГОСТ 15150")] public string Placement { get; set; }
        [Required] [Display(Name = "Размер твердых неабразивных частиц в жидкости, мм")] public double SizeOfParticles { get; set; }
        public List<string> PlacementExplosionCategoryList = new List<string>{ "0", "1", "2", "20", "21", "22"};
        [Required] [Display(Name = "Категория взрывоопасности зоны установки оборудования по ГОСТ Р 51330.9")] public string PlacementExplosionCategory { get; set; }
        [Required] [Display(Name = "Наименование заказчика")] public string CustomerName { get; set; }
        [Required] [Display(Name = "Перекачиваемая жидкость")] public int FluidId { get; set; }
        [ForeignKey("FluidId")] [Display(Name = "Перекачиваемая жидкость")] public virtual Fluid Fluid { get; set; }
        }
    }
