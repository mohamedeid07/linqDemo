//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqToSQL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CU_Program
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CU_Program()
        {
            this.CU_Action = new HashSet<CU_Action>();
            this.CU_Page = new HashSet<CU_Page>();
            this.CU_Role_Program = new HashSet<CU_Role_Program>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public string LogoPath { get; set; }
        public string StatusClass { get; set; }
        public string PREFIX { get; set; }
        public string IconClass { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CU_Action> CU_Action { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CU_Page> CU_Page { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CU_Role_Program> CU_Role_Program { get; set; }
    }
}
