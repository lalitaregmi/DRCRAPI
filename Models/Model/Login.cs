using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    public class Login
    {
        [Required]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
    }
    //class which hold list of model and inherit other class
    /*public class ResponseValues : CommonResponse
    //define a response structure  jasle access ra response garxa in dynamic type of list lai





    {
        public List<dynamic> Values   //values=property
        { get; set; }

    }
    */


}
