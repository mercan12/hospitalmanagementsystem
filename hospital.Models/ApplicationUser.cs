using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hospital.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models
{
    public class ApplicationUser : IdentityUser
    {
       public string Name { get; set; }
        public Gender MyProperty { get; set; }
        public string Nationality { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public string Specialist { get; set; }
        public Department Department { get; set; }
        [NotMapped]
        public ICollection <Appointment> Appointments { get; set; }
        [NotMapped]
        public ICollection<Payroll> Payrolls { get; set; }
    }
}

namespace hospital.Models
{
    public enum Gender
    {
        Male,Female,Other
    }
}