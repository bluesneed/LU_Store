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
    
    public partial class requisition_detail
    {
        public int requisition_detail_id { get; set; }
        public int requisition_detail_qty { get; set; }
        public string requisition_detail_status { get; set; }
        public string requisition_requisition_id { get; set; }
        public string item_item_id { get; set; }
        public int department_department_id { get; set; }
    
        public virtual department department { get; set; }
        public virtual item item { get; set; }
        public virtual requisition requisition { get; set; }
    }
}
