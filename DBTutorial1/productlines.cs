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
    
    public partial class productlines
    {
        public productlines()
        {
            this.products = new HashSet<products>();
        }
    
        public string productLine { get; set; }
        public string textDescription { get; set; }
        public string htmlDescription { get; set; }
        public byte[] image { get; set; }
    
        public virtual ICollection<products> products { get; set; }
    }
}