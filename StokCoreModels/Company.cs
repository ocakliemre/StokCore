namespace StokCoreModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   

    public partial class Company
    {
        
        public Company()
        {
            CompanyAddresses = new HashSet<CompanyAddress>();
            CompanyLogoes = new HashSet<CompanyLogo>();
            Customers = new HashSet<Customer>();
            Messages = new HashSet<Message>();
            Products = new HashSet<Product>();
            Roles = new HashSet<Role>();
            Staffs = new HashSet<Staff>();
            Stores = new HashSet<Store>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string TaxNumber { get; set; }

        public string Password { get; set; }

        public bool IsActive { get; set; }

        public string Email { get; set; }

        public string AuthorizedPerson { get; set;}

        public virtual ICollection<CompanyAddress> CompanyAddresses { get; set; }
      
        public virtual ICollection<CompanyLogo> CompanyLogoes { get; set; }
       
        public virtual ICollection<Customer> Customers { get; set; }
        
        public virtual ICollection<Message> Messages { get; set; }
       
        public virtual ICollection<Product> Products { get; set; }

        public virtual ICollection<Role> Roles { get; set; }

        public virtual ICollection<Staff> Staffs { get; set; }
      
        public virtual ICollection<Store> Stores { get; set; }
    }
}
