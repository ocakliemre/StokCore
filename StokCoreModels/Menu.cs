namespace StokCoreModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Menu
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Language { get; set; }

        public string Link { get; set; }

        public bool IsActive { get; set; }
    }
}
