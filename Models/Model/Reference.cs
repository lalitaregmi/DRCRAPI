using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    public class Reference
    {

       
        public string Category { get; set; }
        
        public string Flag { get; set; }
       
        public string IsActive { get; set; }
       public string UserID { get; set; }





        public object Values { get; set; }
        public string Status { get; set; }
    }
    /*//class which hold list of model and inherit other class
    public class RespValues : CommonResponse
    //define a response structure  jasle access ra response garxa in dynamic type of list lai





    {
        public List<dynamic> Values   //values=property
        { get; set; }

    }
    */
}
