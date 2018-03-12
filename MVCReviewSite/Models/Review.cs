using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCReviewSite.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }

        public string Title { get; set; }

        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime ReviewDate { get; set; }

        public string Location { get; set; }

        [Display(Name = "What I liked")]
        public string Positives { get; set; }

        [Display(Name = "What I didn't like")]
        public string Negatives { get; set; }

        public bool IsRecommended { get; set; }

        [ForeignKey ("Category"), Display(Name = "Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        [ForeignKey("User"), Display(Name = "User Name")]
        public int UserID { get; set; }
        public virtual User User { get; set; }

    }
}