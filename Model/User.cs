using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public enum EnumUserType
        {
            Director =0,
            Official =1
        }
        public EnumUserType UserType { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }


        
    } 
}
