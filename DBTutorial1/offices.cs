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
    
    public partial class offices
    {
        public offices()
        {
            this.employees = new HashSet<employees>();
        }
    
        public string officeCode { get; set; }
        public string city { get; set; }
        public string phone { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string postalCode { get; set; }
        public string territory { get; set; }
    
        public virtual ICollection<employees> employees { get; set; }
    }
}
