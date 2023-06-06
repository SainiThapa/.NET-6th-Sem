using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC_02_22.EntityData
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(50")]
        public string Name { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Address { get; set; }
        [Required]
        public string Contact{ get; set; }
    }
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Column(TypeName ="varchar(50)")]
        public string TeacherName { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }

    }

}
