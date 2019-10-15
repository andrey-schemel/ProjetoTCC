using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TCC.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nome da Empresa")]
        public string Name { get; set; }
        [Required]
        public string Cnpj { get; set; }
        [Required]
        [Display(Name = "Estado")]
        public string State { get; set; }
        [Required]
        [Display(Name = "Cidade")]
        public string City { get; set; }
        [Required]
        [Display(Name = "Rua")]
        public string Street { get; set; }
        [Required]
        [Display(Name = "CEP")]
        public string Cep { get; set; }
        [Required]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Telefone")]
        public string Phone { get; set; }

        [Display(Name = "Categoria dos Serviços Prestados")]
        public Category Category { get; set; }
        [Required]
        [Display(Name = "Categoria dos Serviços Prestados")]
        public int CategoryId { get; set; }


    }
}