using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models.ViewModels
    {
    public class HomeVM
        {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public Product Product { get; set; }
       
        //Общие параметры
        [Display(Name = "Условное наименование")] public string Name { get; set; }
        [Display(Name = "Краткое описание")] public string ShortDesc { get; set; }
        [Display(Name = "Описание")] public string Description { get; set; }
        [Display(Name = "Обозначение")] public string DesignNumber { get; set; }
        
        //Насосные агрегаты
        [Display(Name = "Длина хода ползуна, мм")] public double Stroke_length { get; set; }
        [Display(Name = "Число двойных ходов ползуна в мин.")] public double Strokes { get; set; }
        [Display(Name = "Подача, л/ч")] public double Qapacity { get; set; }
        [Display(Name = "Максимальное давление на выходе, кгс/см2")] public double P2max { get; set; }
        [Display(Name = "Максимальное давление на входе, кгс/см2 (абс.)")] public double P1 { get; set; }
        [Display(Name = "Мощность эДв, кВт")] public double Power { get; set; }
        [Display(Name = "Надкавитационное давление на всасывании, кгс/см2 (абс.)")] public double NPIPR { get; set; }
        [Display(Name = "Условный проход, мм")] public double DN { get; set; }
        [Display(Name = "Возможность регулирования подачи изменением длины хода плунжера на ходу (да/нет)")] public string Adjustable { get; set; }
        [Display(Name = "Исполнение по взрывозащите")] public string ExplosionProofPump { get; set; }
        [Display(Name = "Материал проточной части")] public string MaterialOfFlowPartPump { get; set; }
        [Display(Name = "Тип изделия")] public string TypePump { get; set; }
        [Display(Name = "Статус конструкторской документации")] public string Status { get; set; }

        //ПГА
        [Display(Name = "Тип изделия")] public string TypePGA { get; set; }
        [Display(Name = "Полный газовый объем, л")] public float Volume { get; set; }
        [Display(Name = "Максимальное давление, кгс/см2")] public double P2PGA { get; set; }
        [Display(Name = "Исполнение по взрывозащите")] public string ExplosionProofPGA { get; set; }
        [Display(Name = "Материал проточной части")] public string MaterialOfFlowPartPGA { get; set; }


        //Фильтры

        [Display(Name = "Тип присоединения к фильтру")] public string ConnectType { get; set; }
        [Display(Name = "Величина ячейки, мкм")] public double Cell { get; set; }

        }
    }
