//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBTutorial1
{
    using System;
    using System.Collections.Generic;
    
    public partial class customers
    {
        public customers()
        {
            this.orders = new HashSet<orders>();
            this.payments = new HashSet<payments>();
        }
    
        public int customerNumber { get; set; }
        public string customerName { get; set; }
        public string contactLastName { get; set; }
        public string contactFirstName { get; set; }
        public string phone { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postalCode { get; set; }
        public string country { get; set; }
        public Nullable<int> salesRepEmployeeNumber { get; set; }
        public Nullable<double> creditLimit { get; set; }
    
        public virtual employees employees { get; set; }
        public virtual ICollection<orders> orders { get; set; }
        public virtual ICollection<payments> payments { get; set; }
    }
}
