using AuthenticationService.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationService.Contexts
{
    public class AuthenticationContext : IdentityDbContext<User,Role,Guid>
    {
        public AuthenticationContext(DbContextOptions<AuthenticationContext> options)
        : base(options)
        {
          
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);           
        }

    }
}
