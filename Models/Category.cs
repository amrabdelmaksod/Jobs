using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkStation.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Job Type")]
        public string CategoryName { get; set; }
        [Required]
        [Display(Name ="Type Description")]
        public string CategoryDescription { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }
    }
}