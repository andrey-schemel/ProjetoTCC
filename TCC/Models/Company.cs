using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Models
{
    public class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Cnpj { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string Cep { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public Category Category { get; set; }


    }
}