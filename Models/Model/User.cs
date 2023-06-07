using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    public class User
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Flag { get; set; }
        [Required]
        public string IsActive { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string UserID { get; set; }





        public object Values { get; set; }
        public string Status { get; set; }
    }
    /*//class which hold list of model and inherit other class
    public class RespoValues : CommonResponse
    //define a response structure  jasle access ra response garxa in dynamic type of list lai





    {
        public List<dynamic> Values   //values=property
        { get; set; }

    }
    */


}