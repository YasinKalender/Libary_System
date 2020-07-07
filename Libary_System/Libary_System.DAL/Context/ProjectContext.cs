using Libary_System.Entities.ORM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary_System.DAL.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = @"Server=.; Database=Libarary_System; integrated security=true";
        }

        public DbSet<ActionStatus> ActionStatus { get; set; }

        public DbSet<Author> Author { get; set; }

        public DbSet<Bank> Bank { get; set; }

        public DbSet<Book> Book { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<Criminal> Criminal { get; set; }

        public DbSet<Member> Member { get; set; }

        public DbSet<Personel> Personel { get; set; }

        public DbSet<Contact> Contact { get; set; }

        public DbSet<Message> Message { get; set; }

  

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove <PluralizingTableNameConvention>();


            base.OnModelCreating(modelBuilder);
        }


    }
}
