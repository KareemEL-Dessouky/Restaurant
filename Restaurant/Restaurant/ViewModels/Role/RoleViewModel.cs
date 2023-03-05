using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.ViewModels.Role
{
    public class RoleViewModel
    {
        [MinLength(3)]
        [DisplayName("Role Value")]
        [Required]
        public string RoleName { get; set; }

    }
}
