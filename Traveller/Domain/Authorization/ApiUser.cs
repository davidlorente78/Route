using Microsoft.AspNetCore.Identity;

namespace Domain.Authorization
{
    public class ApiUser : IdentityUser
    {
        //Agregado constructor vacio para intentar arreglar error Injeccion de Dependencias
        public ApiUser() : base() { }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
