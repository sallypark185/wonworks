using System.Data.SqlTypes;

namespace WonWorld.Models
{
    public class Sales
    {
        public int SalesOrderID { get; set; }
        public string SalesOrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerID { get; set; }
        public int Customer { get; set; }
        public Decimal SubTotal { get; set; }

        public Decimal M1 {get;set;}
        public Decimal M2 {get;set;}
        public Decimal M3 {get;set;}
        public Decimal M4 {get;set;}
        public Decimal M5 {get;set;}
        public Decimal M6 {get;set;}
        public Decimal M7 {get;set;}
        public Decimal M8 {get;set;}
        public Decimal M9 {get;set;}
        public Decimal M10 {get;set;}
        public Decimal M11 {get;set;}
        public Decimal M12 {get;set;}
    }
}
