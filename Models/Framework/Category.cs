namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(20,ErrorMessage = "Your Name must include at most 20 character")]
        [Required(ErrorMessage ="Please fill out this field !!!")]
        public string Name { get; set; }

        [StringLength(50)]
        [DisplayName("SEO Title")]
        public string Alias { get; set; }

        public int? ParentID { get; set; }


        public DateTime? CreateDate { get; set; }

        public int? Order { get; set; }

        public bool? Status { get; set; }
    }
}
