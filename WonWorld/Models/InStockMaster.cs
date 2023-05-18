using System.ComponentModel.DataAnnotations;

namespace WonWorld.Models
{
    public class InStockMaster : BaseModel
    {
        [Key]
        public long InmID { get; set; }
        public DateTime InDate { get; set; }
        public decimal? Qty { get; set; }
        public int ItemCount { get; set; }
        public decimal? TotalPrice { get; set; }
    
    }
}
