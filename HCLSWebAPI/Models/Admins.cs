using HCLSWebAPI.CustomDataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCLSWebAPI.Models
{
    [Table("Admins")]
    public class Admins
    {
        [Key]

        public int AdminId { get; set; }
        [Required(ErrorMessage ="Enter your Name")]
        [StringLength(15,ErrorMessage ="Donot Enter more than 15 chars ")]
        
        public string Name { get; set; }
        public string Gender { get; set; }

        [Required(ErrorMessage ="Enter your Email")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password Field is Required")]
        [PasswordValidation()]
        public string Password { get; set; }
        [Required(ErrorMessage = "Address Field is Required")]
        public string Address { get; set; }
        public bool Active { get; set; }

        [ForeignKey("AdminTypes")]
        [Required(ErrorMessage ="ID is Mandatory")]
        [ZeroOrNegativeCheck(ErrorMessage ="Please Select AdminTypeId")]
        public int AdminTypeId { get; set; }

        public AdminTypes AdminTypes { get; set; }
    }
}
