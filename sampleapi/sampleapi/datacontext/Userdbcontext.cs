using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sampleapi.model;

namespace sampleapi.datacontext
{
    public class Userdbcontext : DbContext
    {
        public Userdbcontext(DbContextOptions<Userdbcontext> options) : base(options)
        {

           
        }
        public DbSet<User> user { get; set; }
    }
}
