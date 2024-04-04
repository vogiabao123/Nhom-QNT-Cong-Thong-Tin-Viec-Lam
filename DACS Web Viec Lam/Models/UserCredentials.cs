using System.ComponentModel.DataAnnotations;

namespace DACS_Web_Viec_Lam.Models
{
    public class UserCredentials
    {
        [Required, StringLength(130)]
        public string UserName { get; set; }

        [Required, StringLength(10000)]
        public string Password { get; set; }
    }
}
