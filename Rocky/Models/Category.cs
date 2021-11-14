using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
    {
    public class Category
        {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Тип оборудования")]
        public string Name { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Номер типа оборудования должен быть больше 0")]
        [DisplayName("Номер типа оборудования")]
        public int CategoryNumber { get; set; }

        }
    }
