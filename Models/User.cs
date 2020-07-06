using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionFacturation.Api.Auth;

namespace GestionFacturation.Api.Models
{
    public class User
    {

        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public ApiAccessLevels ApiAccessLevels { get; set; }

    }
}
