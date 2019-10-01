namespace StokCoreModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Role
    {
        public int Id { get; set; }

        public string RoleName { get; set; }

        public string UserName { get; set; }

        public int? CompanyId { get; set; }

        public virtual Company Company { get; set; }
    }
}
