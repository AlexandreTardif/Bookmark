using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Laboratoire1.Models;

namespace Laboratoire1.Data
{
    public class Laboratoire1Context : DbContext
    {
        public Laboratoire1Context (DbContextOptions<Laboratoire1Context> options)
            : base(options)
        {
        }

        public DbSet<Laboratoire1.Models.Bookmark> Bookmark { get; set; }
    }
}
