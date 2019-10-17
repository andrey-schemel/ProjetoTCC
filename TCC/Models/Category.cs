using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TCC.Models
{
    public class Category
    {

        public int Id { get; set; }

        [Required]
        [Display(Name = "Categoria do Serviço Prestado")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Descrição dos Serviços Prestados")]
        public string Description { get; set; }
    }
}