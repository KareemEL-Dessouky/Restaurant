using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Restaurant.ViewModels.Login
{
    public class UserLogin
    {
        [Required]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Remember Me")]
        public bool RememberMe { get; set; }
    }
}
