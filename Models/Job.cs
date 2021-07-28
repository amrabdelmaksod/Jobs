using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WorkStation.Models
{
    public class Job
    {
       
        public int Id { get; set; }
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }
        [Display(Name ="Job Describtion")]
        [AllowHtml]
        public string JobContent { get; set; }
        [Display(Name ="Job Image")]

        public string JobImage { get; set; }
       
        /* One To Many RelationShip*/
        [Display(Name ="Job Type")]
        public int CategoryId { get; set; }
        public string UserId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<ApplyForJob> ApplyForJobs { get; set; }
    }
}