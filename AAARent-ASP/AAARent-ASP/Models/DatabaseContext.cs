using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//neophodno uključiti kako bi se koristili DbContext i DbSet
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using AAARent_ASP.Models;

namespace OOADAspNetMVCEFAzure.Models
{
    public class OOADContext : DbContext
    {
        public OOADContext() : base("AzureConnection") //AzureConnection je naziv connection stringa u Web.config-u
        {
        }
        //dodavanjem klasa iz modela kao DbSet iste će biti mapirane u bazu podataka
        public DbSet<Radnik> radnik { get; set; }
        public DbSet<Klijent> klijent { get; set; }
        public DbSet<Vozilo> vozilo { get; set; }
        public DbSet<Iznajmljivanje> iznajmljivanje { get; set; }

        //Ova funkcija se koriste da bi se ukinulo automatsko dodavanje množine u nazive
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

namespace AAARent_ASP.Models
{
    public class DatabaseContext
    {
    }
}