using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TeslaPower.Models
{
    public class CA
    {
        [Key]
        public int CAid { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        [Required(ErrorMessage = "Date: Can't be Empty")]
        public string date { get; set; }

        [Required(ErrorMessage = "DiNo: Can't be Empty")]
        public string DiNo { get; set; }

        [Required(ErrorMessage = "Plateform Used : Can't be Empty")]
        public int plateFormUsed { get; set; }

        [Required(ErrorMessage = "CA Quantity: Can't be Empty")]
        public int CaQty { get; set; }
        public string remark { get; set; }    
    }
}