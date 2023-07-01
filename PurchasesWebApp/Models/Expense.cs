using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 


namespace PurchasesWebApp.Models
{
    //this is the model class
    public class Expense
    {
        public int ID { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Item { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 4)]
        [Display(Name = "Need or Want")]
        public string NeedOrWant { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public string Date { get; set; }


    }
}
