using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    public class Password
    {
        [Required]
        public string UserID { get; set; }
        [Required]
        public string OldPwd { get; set; }
        [Required]
        public string NewPwd { get; set; }
        
        
    }
    public class ResValues : CommonResponse // for request all req lai yautai response le kam garxa but req chai end point anusar diff.
    {
        public List<dynamic> Values { get; set; }  // Values property(for response) can store  and retrieve the list of object of BlogCategory class
        
    }

}
