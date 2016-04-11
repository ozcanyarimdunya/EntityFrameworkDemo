namespace EntityDemo_Form
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public partial class Person
    {
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }
    }
}
