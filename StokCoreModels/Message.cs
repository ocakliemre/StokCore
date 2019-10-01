namespace StokCoreModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Message
    {
        public int Id { get; set; }

        public string MessageContent { get; set; }

        public int? CompanyId { get; set; }

        public int? StaffId { get; set; }

        public virtual Company Company { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
