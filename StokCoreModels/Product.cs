namespace StokCoreModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            ProductImages = new HashSet<ProductImage>();
        }

        public int Id { get; set; }

        public string ProductCode { get; set; }

        public string ProductName { get; set; }

        public string Content { get; set; }

        public string BarcodeCode { get; set; }

        public string BarcodeCode2 { get; set; }

        public int ShelfNumber { get; set; }

        public int Pieces { get; set; }

        public int MaxPieces { get; set; }

        public int MinPieces { get; set; }

        public decimal Price { get; set; }

        public int TaxRate { get; set; }

        public decimal Total { get; set; }

        public decimal TotalProductValue { get; set; }

        public DateTime InsertionDate { get; set; }

        public bool IsActive { get; set; }

        public int? CompanyId { get; set; }

        public int? StoreId { get; set; }

        public virtual Company Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductImage> ProductImages { get; set; }

        public virtual Store Store { get; set; }
    }
}
