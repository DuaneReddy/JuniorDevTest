using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MVPTest.Models
{
    public class Info
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Display(Name = "Cell Phone Number")]
        [StringLength(10)]
        public string CellNum { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Favourite Colour")]
        public string FavCol { get; set; }

        public virtual Extra Extras { get; set; }


    }
}