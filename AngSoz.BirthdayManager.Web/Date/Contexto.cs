using AngSoz.BirthdayManager.Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngSoz.BirthdayManager.Web.Date
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options)
         : base(options)
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Presente> Presentes { get; set; }


    }
}
