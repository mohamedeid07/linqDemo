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
    
    public partial class DUC_BankDirectForm
    {
        public int ID { get; set; }
        public string DonorNameFromSheet { get; set; }
        public int BankID { get; set; }
        public int BankSheetID { get; set; }
        public string BankAccount { get; set; }
        public System.DateTime PaymentDate { get; set; }
        public double Amount { get; set; }
        public bool IsReviewed { get; set; }
    
        public virtual DUC_Bank DUC_Bank { get; set; }
        public virtual DUC_BankSheet DUC_BankSheet { get; set; }
    }
}
