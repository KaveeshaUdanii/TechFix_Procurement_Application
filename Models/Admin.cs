using System.ComponentModel.DataAnnotations;

namespace ProcurementAPI.Models
{
    public class Admin
    {
        [Key]
        public string AID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ContactNo { get; set; }
    }

}
