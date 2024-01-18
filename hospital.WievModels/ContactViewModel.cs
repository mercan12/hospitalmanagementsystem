using hospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.WievModels
{
    public class ContactViewModel
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int HospitalInfoId { get; set; }


        public ContactViewModel() 
        {
        }

        public ContactViewModel(Contact model)
        {
            Id = model.Id;
            Phone = model.Phone;
            Email = model.Email;
            HospitalInfoId = model.HospitalId;
        }

        public Contact ConvertViewModel(ContactViewModel model)
        {
            return new Contact
            {
                Id = model.Id,
                Phone = model.Phone,
                Email = model.Email,
                HospitalId = model.HospitalInfoId
        };
        }
    }
}
