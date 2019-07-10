using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DemoWebApplication1.Models
{
    public class Customer
    {
        public int id { set; get; }
        [Required]
        [StringLength(5)]
        public string Firstname { set; get; }
        [Display (Name ="Last Name")]
        public string Lastname { set; get; }

        //public virtual IList< >
    }
}
