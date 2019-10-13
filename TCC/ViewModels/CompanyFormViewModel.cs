using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TCC.Models;

namespace TCC.ViewModels
{
    public class CompanyFormViewModel
    {
        public Company Company { get; set; }
        public List<Category> Categories { get; set; }
        
    }
}