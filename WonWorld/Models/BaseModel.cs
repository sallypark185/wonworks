namespace WonWorld.Models
{
    public class BaseModel
    {
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }

        public bool IsRemove { get; set; }
        public bool IsUse { get; set; }
    }
}
