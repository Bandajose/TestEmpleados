namespace Examen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employ")]
    public partial class Employ
    {
        [Key]
        public int IdEmploy { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(15)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(320)]
        public string Email { get; set; }

        public int IdDepartment { get; set; }

        public virtual Department Department { get; set; }
    }
}
