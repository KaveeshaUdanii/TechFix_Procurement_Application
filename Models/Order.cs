using System.ComponentModel.DataAnnotations;

namespace ProcurementAPI.Models
{
    public class Order
    {
        [Key]
        public string OID { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OrderPlacedDate { get; set; }
        public string PID { get; set; }
        public string SID { get; set; }
        public Product Product { get; set; }
    }

}
