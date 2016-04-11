namespace EntityDemo_Form
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DemoModel : DbContext
    {
        public DemoModel()
            : base("name=DemoModel")
        {
        }

        public virtual DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
