using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registro_de_Usuarios_ASP_NET.Models
{
    public class ApplicationUserModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
    }
}
