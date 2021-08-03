using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.ViewModels
{
    public class InsureeVm //creating a view model in order to pass only specific information from db to the Admin view
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public decimal Quote { get; set; }
    }
}