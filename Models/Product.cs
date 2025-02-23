using System.ComponentModel.DataAnnotations;

namespace ProcurementAPI.Models
{
    public class Product
    {
        [Key]
        public string PID { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
        public string SID { get; set; }
        public Supplier Supplier { get; set; }
    }

}
