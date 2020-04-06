using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace restfull_net.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProduct { get; set; }
        
        [Display(Name="Enter Product Code")]
        [StringLength(20)]
        [Required(ErrorMessage="{0} Is required")]
        public string ProductCode { get; set; }

        [Display(Name="Enter Product Type")]
        [StringLength(50)]
        [Required(ErrorMessage="{0} Is required")]
        public string ProductType { get; set; }

        [Display(Name="Enter Product Description")]
        [StringLength(150)]
        [Required(ErrorMessage="{0} is required")]
        public string ProductDescription { get; set; }

        [Display(Name="Unit Price")]
        [DisplayFormat(DataFormatString ="{0:C}")]
        [Required(ErrorMessage="{0} is required")]
        public decimal UnitPrice { get; set; }

        [Display(Name="Quantity in Stock")]        
        [Required(ErrorMessage="{0} is required")]
        public int QtyStock { get; set; }

    }
}