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
    
    public partial class CU_Department
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CU_Department()
        {
            this.CU_Department1 = new HashSet<CU_Department>();
            this.CU_Employee = new HashSet<CU_Employee>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Descriptoin { get; set; }
        public int IdHeadDepartment { get; set; }
        public bool IsDeleted { get; set; }
        public string MainTask { get; set; }
        public Nullable<int> IdParent { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CU_Department> CU_Department1 { get; set; }
        public virtual CU_Department CU_Department2 { get; set; }
        public virtual CU_HeadDepartment CU_HeadDepartment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CU_Employee> CU_Employee { get; set; }
    }
}
