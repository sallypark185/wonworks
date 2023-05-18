using System.ComponentModel.DataAnnotations;

namespace WonWorld.Models
{
    public class InStockDetail : BaseModel
    {
        [Key]
        public long IndID { get; set; }
        public long InmID { get; set; }
        public DateTime InDate { get; set; }
        public string? ItemCode { get; set; }
        public decimal? Qty { get; set; }
        public int Cnt { get; set; }
        public decimal? ItemPrice { get; set; }
    
    }
}
