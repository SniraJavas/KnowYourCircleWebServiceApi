//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KnowYourCircleWebServiceApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Project
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Project()
        {
            this.Users1 = new HashSet<Users1>();
        }
    
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string Location { get; set; }
        public string TeamLead { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Stacks { get; set; }
        public string ClosestOffice { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Users1> Users1 { get; set; }
    }
}
