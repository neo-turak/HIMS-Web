using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIMS_Web.Models
{
   
    public class Products
    {
        [Key]
        [Column("P_ID",Order =0,TypeName ="int")]
        [Display(Name="序号")]
        public int ID { get; set; }

        [Column("Name",TypeName ="nvarchar(255)")]
        [Display(Name="产品名")]
        public string Name { get; set; }

        [Column("Type", TypeName = "nvarchar(255)")]
        [Display(Name="类型")]
        public string Type { get; set; }

        [Column("Location",TypeName="nvarchar(255)")]
        [Display(Name="位置")]
        public string Location { get; set; }

        [Column("Price",TypeName ="float")]
        [Display(Name="价格")]
        //[DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Column("Owner",TypeName ="nvarchar(32)")]
        [Display(Name="店主")]
        public string Owner { get; set; }
    }

   
}
