namespace StokCoreModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Store
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Store()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string StoreManager { get; set; }

        public bool IsActive { get; set; }

        public int? CompanyId { get; set; }

        public virtual Company Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
