using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TeslaPower.Models
{
    public class Item
    {
        public int ItemId { get; set; }


        [Display(Name = "KVA")]
        [Required(ErrorMessage = "KVA : Can't be Empty")]
        [RegularExpression("[0-9]{2,7}", ErrorMessage = "KVA : Only Numbers are allowed ")]             
        public int kva { get; set; }
     

        [Display(Name = "KV")]
        [Required(ErrorMessage = "KV : Can't be Empty")]
        [RegularExpression("[0-9]{2,7}", ErrorMessage = "KV: Only Numbers are allowed ")]
        public int kv{ get; set; }


        [Display(Name = "Quantity")]
        [Required(ErrorMessage = "Quantity : Can't be Empty")]
        [RegularExpression("[0-9]{1,5}", ErrorMessage = "Quantity: Only Numbers are allowed ")]
        public int qty { get; set; }


        [Display(Name = "Type")]
        [Required(ErrorMessage = "Type : Can't be Empty")]
        public string type { get; set; }

        [Display(Name = "Start Code No.")]
        [Required(ErrorMessage = "Start Code No : Can't be Empty")]
        [RegularExpression("[0-9]{1,10}", ErrorMessage = "Start Code No: Only Numbers are allowed ")]
        public int scn { get; set; }     

        [Column("Winding", TypeName = "Varchar")]
        [Display(Name = "Winding Type")]
        [Required(ErrorMessage = "Winding : Can't be Empty")]
        [RegularExpression("[a-zA-Z]{1,12}", ErrorMessage = "Winding: Only alphabets charecters are allowed ")]
        public string winding { get; set; }

        [Display(Name = "Tap Changer")]
        [Column("TapChanger", TypeName = "Varchar")]
        [Required(ErrorMessage = "TapChanger : Can't be Empty")]
        [RegularExpression("[a-zA-Z]{1,3}", ErrorMessage = "TapChanger: Only alphabets charecters are allowed ")]
        public string tapchanger { get; set; }


        [Column("UnitPrice", TypeName = "Money")]
        [Display(Name = "Unit Price")]
        [Required(ErrorMessage = "Unit Price : Can't be Empty")]
        public decimal up { get; set; }

        [Column("DiNo", TypeName = "Varchar")]
        [Display(Name = "Di Ref. No")] 
        public string DiNo { get; set; }

        [Display(Name = "Purchage No:")]
        [Required(ErrorMessage = "Purchage No : Can't be Empty")]      
        public int poNo { get; set; }

        [ForeignKey("poNo")]
        public Order order { get; set; }
    }
}