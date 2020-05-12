using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIMS_Web.Models
{
    public class Locations
    {

        [Key]
        [Column("ID",Order =0,TypeName ="int")]
        [Display(Name="序号")]
        public int ID { get; set; }

        [Column("Name",Order =1,TypeName ="nvarchar(32)")]
        [Display(Name="库房名")]
        public string Name { get; set; }

        [Column("Capacity",Order =2,TypeName ="int")]
        [Display(Name="容量")]
        public int Capacity { get; set; }

        [Column("Owner",Order =3,TypeName ="Nvarchar(32)")]
        [Display(Name="户主")]
        public string Owner { get; set; }
    
    }
}
