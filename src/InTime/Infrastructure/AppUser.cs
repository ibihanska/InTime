using System;
using Microsoft.AspNetCore.Identity;

namespace InTime.Infrastructure
{
    public class AppUser : IdentityUser<Guid>
    {
        public string DisplayName { get; set; }
    }
}