using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BD.Tms.Domain
{

    public class User
    {
        
       
        public string Id { get; set; }
      
        public string UserName { get; set; }
      
        public string Password { get; set; }
       
        public string Email { get; set; }
       
        public string Phone { get; set; }
       
        public string Address { get; set; }
     
    }
}
