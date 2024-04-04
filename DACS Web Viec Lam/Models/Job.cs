using System.ComponentModel.DataAnnotations;

namespace DACS_Web_Viec_Lam.Models
{
    public class Job
    {
        public int JobId { get; set; }

        [Required(ErrorMessage = "Please provide a job title.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please provide a job description.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please provide the job location.")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Please provide the job Salary.")]
        [Range(0, double.MaxValue, ErrorMessage = "Salary must be a non-negative value.")]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = "Please provide the job Requirement.")]
        public string Requirement { get; set; }

        [Required(ErrorMessage = "Please specify the application deadline.")]
        
        public DateTime ApplicationDeadline { get; set; }
    }


}
