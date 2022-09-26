using DTSMCC_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTSMCC_WebApp.ViewModels
{
    public class CreateViewModel
    {
        public IEnumerable<Department> Departments { get; set; }
        public IEnumerable<Division> Divisions { get; set; }
    }
}
