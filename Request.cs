namespace projectEFullstacl
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Request")]
    public partial class Request
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Request_no { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        public int? Quantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Request_date { get; set; }

        public int? Pcode { get; set; }

        [StringLength(50)]
        public string Wname { get; set; }

        [StringLength(50)]
        public string Sname { get; set; }

        public virtual Product Product { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual Warehouse Warehouse { get; set; }
    }
}
