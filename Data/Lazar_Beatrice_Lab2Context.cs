using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lazar_Beatrice_Lab2.Models;

namespace Lazar_Beatrice_Lab2.Data
{
    public class Lazar_Beatrice_Lab2Context : DbContext
    {
        public Lazar_Beatrice_Lab2Context(DbContextOptions<Lazar_Beatrice_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Lazar_Beatrice_Lab2.Models.book> book { get; set; } = default!;
        public DbSet<Lazar_Beatrice_Lab2.Models.Publisher>? Publisher { get; set; }

    }
}

