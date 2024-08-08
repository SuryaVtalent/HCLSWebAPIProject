using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCLSWebAPI.Models
{
    [Table("AdminTypes")]
    public class AdminTypes
    {
        [Key]
        public int AdminTypeId {get; set; }

        public string AdminTypeName { get; set; }

        public ICollection<Admins>Admins { get; set; }
    }
}
