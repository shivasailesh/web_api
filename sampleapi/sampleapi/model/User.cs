using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sampleapi.model
{
    [Table("table_users")]
    public class User
    {
        [Key]
        public int user_id { get; set; }

        public  string username { get; set; }

        
       public string password { get; set; }

        public string email { get; set; }

        public string full_name{ get; set; }

        public string  contact{ get; set; }

        public string address { get; set; }


    }
}
