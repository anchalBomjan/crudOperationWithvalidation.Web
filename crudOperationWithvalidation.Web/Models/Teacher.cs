using crudOperationWithvalidation.Web.CustomValidation;
using System.ComponentModel.DataAnnotations;

namespace crudOperationWithvalidation.Web.Models
{
    public class Teacher
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [SkillsValidate(Allowed = new string[] { "ASP.NET Core", "ASP.NET MVC", "ASP.NET Web Forms" }, ErrorMessage = "You skills are invalid")]
        public string Skills {  get; set; }

        [Range(5, 50)]
        public  int TotalStudent { get; set; }

        [Required]
        public decimal Salary {  get; set; }


        [Required]
        public DateTime AddedOn { get; set; }

    }
}
