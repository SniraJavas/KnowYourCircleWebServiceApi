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
    
    public partial class NoticeBoard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NoticeBoard()
        {
            this.Users1 = new HashSet<Users1>();
        }
    
        public int Id { get; set; }
        public string Topic { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public System.DateTime Date { get; set; }
        public string Reactions { get; set; }
        public string Poster { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Users1> Users1 { get; set; }
    }
}