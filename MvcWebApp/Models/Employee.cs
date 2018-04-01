using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebApp.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public bool IsMarried { get; set; }

        public IList<string> Sex { get; set; }

        public IList<string> Qualification { get; set; }

        public string CountryId { get; set; }

        public IList<SelectListItem> Country { get; set; }

        public IList<string> States { get; set; }

        public string Notes { get; set; }
    }
}