using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TeslaPower.Models
{
    public class Order
    {
        [Column("OrderTo", TypeName = "Varchar")]
        [Required(ErrorMessage ="Order To : Can't be Empty")]
        [MinLength(2, ErrorMessage = "Order To : Only Accepted 'TTL' or 'TP' ")]
        [MaxLength(3, ErrorMessage = "Order To : You Can't Enter More Then 3 charecters ")]
        [RegularExpression("[a-zA-Z]{2,3}", ErrorMessage = "Order To : Only Alphabets are allowed")]
        public string orderTo { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name ="Purchage No:")]
        [Required(ErrorMessage = "Purchage No : Can't be Empty")]      
        [RegularExpression("[0-9]{6,10}", ErrorMessage = "Purchage No: Only Numbers are allowed ")]
        public int poNo { get; set; }


        [DataType(DataType.Date)]
        [Display(Name = "Purchage Date:")]
        [Required(ErrorMessage = "Purchage Date: Can't be Empty")]     
        public String poDate { get; set;}

        [Column("Cname", TypeName = "Varchar")]
        [Display(Name = "Customer Name:")]
        [Required(ErrorMessage = "Customer Name: Can't be Empty")]
        [RegularExpression("[a-zA-Z \\s]{2,50}", ErrorMessage = "Customer Name: Only Alphabets are allowed ")]
        [MaxLength(50)]
        public String custName { get; set; }

        [Column("region", TypeName = "Varchar")]
        [Display(Name = "Region")]
        [Required(ErrorMessage = "Region : Can't be Empty")]
        [MaxLength(3, ErrorMessage = "Region : Maximum 3 charecters allowed ")]
        public string region { get; set; }


        [Column("inspection", TypeName = "Varchar")]
        [Display(Name = "Inspection")]
        [Required(ErrorMessage = "Inspection : Can't be Empty")]
        [MaxLength(20, ErrorMessage = "Inspection : Maximum 15 charecters  are allowed ")]
        public string inspection { get; set;}

        [Column("delConfirm", TypeName = "Varchar")]
        [MaxLength(3)]
        [Display(Name = "Delivery Confirmation")]       
        public String delConfirm { get; set; }

        
        [Display(Name = "Delivery Date:")]
        [DataType(DataType.Date)]
        public string delDate { get; set; }

       
        [Display(Name = "Remark")]       
        [MaxLength(150)]
        [DataType(DataType.MultilineText)]
        public string remark { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}