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
    
    public partial class CU_Role_Page
    {
        public int ID { get; set; }
        public int IdPage { get; set; }
        public int IdRoleProgram { get; set; }
        public string Permission { get; set; }
    
        public virtual CU_Page CU_Page { get; set; }
        public virtual CU_Role_Program CU_Role_Program { get; set; }
    }
}