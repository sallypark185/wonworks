using System.ComponentModel.DataAnnotations;

namespace WonWorld.Models
{
    public class Users : BaseModel
    {
        [Key]
        public long UID{ get; set; }
          public string? UserName{ get; set; }
        public string? LoginID{ get; set; }
        public string? Password{ get; set; }
    }
}
