using System.ComponentModel.DataAnnotations;

namespace AspNetCoreCrudDemo.Models
{
    public class Student
    {
        [Key]
        [Display(Name="Student ID") ]
        public int StudentId { get; set; }

        [Required]
        [Display(Name = "Student Name")]
        public string  Name{ get; set; }

        [Required]
        public string Email  { get; set; }

        [Required]
        public string Course { get; set; }

        [Display(Name = "EnrollementDate")]
        public DateTime EnrollementDate { get; set; }
    }
}
