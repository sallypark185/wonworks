namespace WonWorld.Models
{
    public class Users
    {
          public string? UserName{ get; set; }
        public long UID{ get; set; }
        public string? LoginID{ get; set; }
        public DateTime? CreateDate{ get; set; } 
        public string? CreateUser{ get; set; }
        public DateTime? UpdateDate{ get; set; }
        public string? UpdateUser{ get; set; }
        public string? Password{ get; set; }
    }
}
