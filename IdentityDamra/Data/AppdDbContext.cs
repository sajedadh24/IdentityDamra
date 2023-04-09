using IdentityDamra.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityDamra.Data
{
    public class AppdDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppdDbContext(DbContextOptions<AppdDbContext> Option) : base(Option)
        {

        }



    }
    
}
