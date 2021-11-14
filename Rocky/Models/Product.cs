using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
    {
    public class Product
        {
        //Общие параметры
        [Key]public int Id { get; set; }
        [Required][Display(Name = "Условное наименование")] public string Name { get; set; }
        [Display(Name = "Краткое описание")] public string ShortDesc { get; set; }
        [Display(Name = "Описание")] public string Description { get; set; }
        [Required][Display(Name = "Обозначение")] public string DesignNumber { get; set; }
        [Display(Name = "Изображение")] public string Image { get; set; }
        [Required][Display(Name = "Тип оборудования")] public int CategoryId { get; set; }
        [ForeignKey("CategoryId")][Display(Name = "Тип оборудования")] public virtual Category Category { get; set; }
        [Required][Display(Name = "Область применения")] public int ApplicationTypeId { get; set; }
        [ForeignKey("ApplicationTypeId")] [Display(Name = "Область применения")] public virtual ApplicationType ApplicationType { get; set; }
        [Required][Display(Name = "Статус конструкторской документации")] public string Status { get; set; }
        [Display(Name = "Минимальная температура перекачиваемой среды °С")] public double minTemp { get; set; }
        [Display(Name = "Максимальная температура перекачиваемой среды °С")] public double maxTemp { get; set; }

        //Насосные агрегаты
        [Display(Name = "Длина хода ползуна, мм")] public decimal Stroke_length { get; set; }
        [Display(Name = "Число двойных ходов ползуна в мин.")] public decimal Strokes { get; set; }
        [Display(Name = "Подача, л/ч")] public double Qapacity { get; set; }
        [Display(Name = "Максимальное давление на выходе, кгс/см2")] public double P2max { get; set; }
        [Display(Name = "Максимальное давление на входе, кгс/см2 (абс.)")] public double P1 { get; set; }
        [Display(Name = "Мощность эДв, кВт")] public double Power { get; set; }
        [Display(Name = "Надкавитационное давление на всасывании, кгс/см2 (абс.)")] public double NPIPR { get; set; }
        [Display(Name = "Условный проход, мм")] public double DN { get; set; }
        [Display(Name = "Возможность регулирования подачи изменением длины хода плунжера на ходу (да/нет)")] public string Adjustable { get; set; }
        [Display(Name = "Исполнение по взрывозащите")] public string ExplosionProofPump { get; set; }
        [Display(Name = "Материал проточной части")] public int FluidPartMatreialId { get; set; }
        [ForeignKey("FluidPartMatreialId")] [Display(Name = "Материал проточной части")] public virtual FluidPartMaterial FluidPartMaterial { get; set; }
        [Display(Name = "Тип изделия")] public string TypePump { get; set; }

        //ПГА
        [Display(Name = "Тип изделия")] public string TypePGA { get; set; }
        [Display(Name = "Полный газовый объем, л")] public double Volume { get; set; }
        [Display(Name = "Максимальное давление, кгс/см2")] public double P2PGA { get; set; }
        [Display(Name = "Исполнение по взрывозащите")] public string ExplosionProofPGA { get; set; }


        //Фильтры

        [Display(Name = "Тип присоединения к фильтру")] public string ConnectType { get; set; }
        [Display(Name = "Величина ячейки, мкм")] public double Cell { get; set; }
        }
    }
