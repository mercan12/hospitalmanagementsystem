﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Company    { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Addres { get; set; }
        public ICollection<MedicineReport> MedicineReports { get; set;}
    }
}
