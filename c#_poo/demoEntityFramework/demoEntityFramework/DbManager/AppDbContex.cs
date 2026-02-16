using demoEntityFramework.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoEntityFramework.DbManager
{
    internal class AppDbContex :DbContext
    {
      public DbSet<Personne> Personne {  get; set; }





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
               "server=localhost;database=ef;uid=root;pwd=",
               ServerVersion.AutoDetect("server=localhost;database=ef;uid=root;pwd=")



                );
        }
    }
}
