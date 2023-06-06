using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    public class Account
    {
        [Required]
        public string ComID { get; set; }
        [Required]
        public string UserID { get; set; }
        [Required]
        public string Flag { get; set; }
        [Required]
        public string Date { get; set; }
        public string Particulars { get; set; }
        public string DrAmt { get; set; }
        public string CrAmt { get; set; }
        public string Status { get; set; }
    }
    }

