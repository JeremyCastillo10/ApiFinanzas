using Microsoft.AspNetCore.Identity;

namespace ApiFinanzas.Models
{
    public class Usuario: IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
}
