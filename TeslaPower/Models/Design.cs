using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TeslaPower.Models
{
    public class Design
    {
        //basic attributes
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("DiNo", TypeName = "Varchar")]
        [Required(ErrorMessage = "DI No : Can't be Empty")]
        [RegularExpression("[a-zA-Z0-9]{3,10}", ErrorMessage = "Di No : Only Alpha-nemeric charecters are allowed")]
        public string DiNo { get; set; }

        [Column("Rating", TypeName = "Varchar")]
        [Required(ErrorMessage = "Rating : Can't be Empty")]
        [RegularExpression("[a-zA-Z0-9*]{2,10}", ErrorMessage = "Rating : Only Alpha-nemeric charecters are allowed")]
        public string Rating { get; set; }

        [Column("CustName", TypeName = "Varchar")]
        [Display(Name = "Customer Name")]
        [Required(ErrorMessage = "CustName : Can't be Empty")]
        [RegularExpression("[a-zA-Z\\s]{2,50}", ErrorMessage = "CustName : Only Alphabet charecters are allowed")]
        public string Cname { get; set; }

        [Column("Type", TypeName = "Varchar")]
        [RegularExpression("[a-zA-Z0-9*/-]{2,10}", ErrorMessage = "Type : Only Alpha-nemeric charecters are allowed")]
        public string Type { get; set; }


        [RegularExpression("[0-9]{1,6}", ErrorMessage = "Type : Only nemeric charecters are allowed")]
        public int? Qty { get; set; }

        [Display(Name = "CRGO/Set (kg)")]
        [RegularExpression("[0-9.]{1,8}", ErrorMessage = "CRGO : Only nemeric charecters are allowed")]
        public double Crgo { get; set; }

        // Conductor Attributes

        [Column("Conductor", TypeName = "Varchar")]
        [Display(Name = "Conductor Type")]
        [Required(ErrorMessage = "Conductor : Can't be Empty")]
        public string Conductor { get; set; }

        // LV 

        [Display(Name = "LV Size")]
        [Required(ErrorMessage = "Lv Sise : Can't be Empty")]
        [RegularExpression("[0-9.]{1,8}", ErrorMessage = "LV Size : Only  Numeric  charecters are allowed")]
        public double LvSize { get; set; }

        [Display(Name = "LV Covered Size")]
        [Required(ErrorMessage = "Lv Covered Sise : Can't be Empty")]
        [RegularExpression("[0-9.]{1,8}", ErrorMessage = "LV Covered Size : Only  numeric  charecters are allowed")]
        public double LvCSize { get; set; }

        [Display(Name = "LV A")]
        [Required(ErrorMessage = "Lv A : Can't be Empty")]
        [RegularExpression("[0-9]{1,8}", ErrorMessage = "LV A: Only  numeric  charecters are allowed")]
        public int LvA { get; set; }

        [Display(Name = "LV R")]
        [Required(ErrorMessage = "Lv R : Can't be Empty")]
        [RegularExpression("[0-9]{1,8}", ErrorMessage = "LV R : Only  -numeric  charecters are allowed")]
        public int LvR { get; set; }

        [Display(Name = "LV Weight")]
        [Required(ErrorMessage = "Lv Weight : Can't be Empty")]
        [RegularExpression("[0-9.]{1,8}", ErrorMessage = "LV Weight : Only  numeric  charecters are allowed")]
        public double LvWeight { get; set; }

        //HV

        [Column("HvType", TypeName = "Varchar")]
        [Display(Name = "HV Type")]
        [Required(ErrorMessage = "Hv Type : Can't be Empty")]

        public string HvType { get; set; }

        [Display(Name = "HV Size")]
        [Required(ErrorMessage = "Lv Sise : Can't be Empty")]
        [RegularExpression("[0-9.]{1,8}", ErrorMessage = "HV Size : Only  Numeric  charecters are allowed")]
        public double HvSize { get; set; }

        [Display(Name = "HV Covered Size")]
        [Required(ErrorMessage = "Hv Covered Sise : Can't be Empty")]
        [RegularExpression("[0-9.]{1,8}", ErrorMessage = "HV Covered Size : Only  numeric  charecters are allowed")]
        public double HvCSize { get; set; }

        [Display(Name = "HV A")]
        [RegularExpression("[0-9]{1,8}", ErrorMessage = "HV A: Only  numeric  charecters are allowed")]
        public int HvA { get; set; }

        [Display(Name = "HV R")]
        [RegularExpression("[0-9]{1,8}", ErrorMessage = "HV R : Only  -numeric  charecters are allowed")]
        public int HvR { get; set; }

        [Display(Name = "HV Weight")]
        [Required(ErrorMessage = "Hv Weight : Can't be Empty")]
        [RegularExpression("[0-9.]{1,8}", ErrorMessage = "HV Weight : Only  numeric  charecters are allowed")]
        public double HvWeight { get; set; }

        //tap Changer attributes

        [Column("TapChanger", TypeName = "Varchar")]
        [Display(Name = "Tap Changer")]
        [Required(ErrorMessage = "Tap Changer : Can't be Empty")]

        public string TapChanger { get; set; }

        [RegularExpression("[a-zA-Z0-9.]{1,5}", ErrorMessage = "Tap Changer Range : Only  Alpha-Numeric  charecters are allowed")]
        public string TcRange { get; set; }

        [RegularExpression("[a-zA-Z0-9.]{1,5}", ErrorMessage = "Tap Changer rating : Only  Alpha-Numeric charecters are allowed")]
        public string TcRating { get; set; }

        // Radiator attributes
        [Column("RadiatorType", TypeName = "Varchar")]
        [Display(Name = "Radiator Type")]
        [Required(ErrorMessage = "Radiator Type : Can't be Empty")]
        public string RadiatorType { get; set; }

        [Display(Name = "Radiator size")]
        [RegularExpression("[0-9.]{1,5}", ErrorMessage = "Radiator Range : Only  Numeric  charecters are allowed")]
        public double? RSize { get; set; }

        [Display(Name = "Radiator Qty")]
        [RegularExpression("[0-9.]{1,5}", ErrorMessage = "Radiator rating : Only  Numeric charecters are allowed")]
        public int? RQty { get; set; }

        [Display(Name = "Panel 1 size")]
        [RegularExpression("[0-9.]{1,5}", ErrorMessage = "Panel 1 Range : Only  Numeric  charecters are allowed")]
        public double? p1Size { get; set; }

        [Display(Name = "Panel 1 Qty")]
        [RegularExpression("[0-9.]{1,5}", ErrorMessage = "Panel 1 rating : Only  Numeric charecters are allowed")]
        public int? p1Qty { get; set; }
        [Display(Name = "Panel 2 size")]
        [RegularExpression("[0-9.]{1,5}", ErrorMessage = "Panel 2 Range : Only  Numeric  charecters are allowed")]
        public double? p2Size { get; set; }

        [Display(Name = "Panel 2 Qty")]
        [RegularExpression("[0-9.]{1,5}", ErrorMessage = "Panel 2 rating : Only  Numeric charecters are allowed")]
        public int? p2Qty { get; set; }

        public bool status { get; set; }
    }
}