using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SetupProject.Models
{
    public enum ApprovalStatus { Yes, Pending, No }
    public class Review
    {
        [Display(Name = "Review ID")]
        public Int32 ReviewID { get; set; }


        [Display(Name = "Description")]
        [StringLength(100, ErrorMessage = "100 characters max")]
        public String Description { get; set; }



        [Display(Name = "Rating")]
        [Range(1, 5, ErrorMessage = "Betweeen 1 to 5 stars")]
        [DisplayFormat(DataFormatString = "{0:#.#}")]
        public Int16 Rating { get; set; }

        public ApprovalStatus? ApprovalStatus { get; set; }

        public Book Book { get; set; }

        //WRITER???
        public AppUser Author { get; set; }
    }
}
