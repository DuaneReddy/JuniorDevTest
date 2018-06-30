using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVPTest.Models
{
    public class Extra
    {
        [ForeignKey("Infos")]
        [Key]
        public int Id { get; set; }

        [Display(Name ="Favourite Music")]
        public string Music { get; set; }

        [Display(Name = "Favourite TV Show")]
        public string Tv { get; set; }

        [Display(Name = "Favourite Soccer Team")]
        public string Soccer { get; set; }

        public virtual Info Infos { get; set; }
    }
}