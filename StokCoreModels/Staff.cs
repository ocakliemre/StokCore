namespace StokCoreModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            Messages = new HashSet<Message>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [StringLength(35)]
        public string Name { get; set; }

        [Required]
        [StringLength(35)]
        public string Surname { get; set; }

        [StringLength(13)]
        public string Phone { get; set; }

        public int? CompanyId { get; set; }

        [StringLength(40)]
        public string Department { get; set; }

        [StringLength(35)]
        public string Task { get; set; }

        public bool IsActive { get; set; }

        [Required]
        [StringLength(45)]
        public string Email { get; set; }

        public virtual Company Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message> Messages { get; set; }
    }
}
