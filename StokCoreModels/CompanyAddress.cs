namespace StokCoreModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   

    public partial class CompanyAddress
    {
        public int Id { get; set; }

        public string Address { get; set; }

        public int? CompanyId { get; set; }

        public virtual Company Company { get; set; }
    }
}
