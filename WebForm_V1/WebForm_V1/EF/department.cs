//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebForm_V1.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class department
    {
        public department()
        {
            this.department_detail = new HashSet<department_detail>();
            this.disbursement_list = new HashSet<disbursement_list>();
            this.employees = new HashSet<employee>();
            this.requisition_detail = new HashSet<requisition_detail>();
        }
    
        public int department_id { get; set; }
        public string department_name { get; set; }
        public string department_code { get; set; }
        public string department_contact_name { get; set; }
        public int department_tel { get; set; }
        public int department_fax { get; set; }
    
        public virtual ICollection<department_detail> department_detail { get; set; }
        public virtual ICollection<disbursement_list> disbursement_list { get; set; }
        public virtual ICollection<employee> employees { get; set; }
        public virtual ICollection<requisition_detail> requisition_detail { get; set; }
    }
}
