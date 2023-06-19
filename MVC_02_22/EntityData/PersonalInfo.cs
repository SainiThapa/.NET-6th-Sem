using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_02_22.EntityData
{
    [Table("PersonalInfo")]
    public class PersonalInfo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }


    }
}
