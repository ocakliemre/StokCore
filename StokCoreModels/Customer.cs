namespace StokCoreModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string CompanyName { get; set; }

        public string Taxnumber { get; set; }

        public int? CompanyId { get; set; }

        public virtual Company Company { get; set; }
    }
}
