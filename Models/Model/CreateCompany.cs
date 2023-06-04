using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    public class CreateCompany
    {
        [Required]
        public string  ComID{ get; set; }
        public string UserID { get; set; }
        [Required]
        public string Flag { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        [Required]
        public string Contact { get; set; } 
        public string ContactPerson { get; set; }
        [Required]
        public string Category { get; set; }

        public string Description { get; set; }
        public string IsActive { get; set; }
        public string Status { get; set; }
    }
}
