using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SetupProject.Models
{
    public class ProcurementOrder
    {
        public Int32 ProcurementOrderID { get; set; }

        [Display(Name = "Procurement Date:")]
        [DisplayFormat(DataFormatString = "{0:MM.dd.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ProcurementDate { get; set; }

        [Display(Name = "Procurement Status:")]
        public Boolean Status { get; set; }

        [Display(Name = "Procurement Order Number:")]
        public Int32 ProcurementOrderNumber { get; set; }

        public AppUser Manager { get; set; }
        public List<ProcurementDetail> ProcurementDetails { get; set; }

        public ProcurementOrder()
        {
            if (ProcurementDetails == null)
            {
                ProcurementDetails = new List<ProcurementDetail>();
            }
        }
    }
}
