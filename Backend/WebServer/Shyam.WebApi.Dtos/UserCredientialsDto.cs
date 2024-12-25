using System.ComponentModel.DataAnnotations;

namespace Shyam.WebApi.Dtos
{
    public class UserCredientialsDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
