using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Psoft.Domain;

namespace Psoft.Data
{
    public class PsoftDBContext :DbContext
    {
        public PsoftDBContext(DbContextOptions<PsoftDBContext> options) : base(options)
        { }

        public DbSet<Users> users { get; set; }
        public DbSet<Projects> projects { get; set; }

        public DbSet<BOQ> BOQS { get; set; }

    }
}
