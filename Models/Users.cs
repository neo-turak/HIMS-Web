using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Text;

namespace HIMS_Web.Models
{
    public partial class Users
    {

        [Key]
        [Column(name: "ID", Order = 0, TypeName = "int")]
        public int Id { get; set; }

        [Column(name: "Username", Order = 1, TypeName = "nvarchar(32)")]
        [Display(Name = "用户名")]
        public string Username { get; set; }

        [Column(name: "Password", Order = 2, TypeName = "nvarchar(32)")]
        [Display(Name = "密码")]
        public string Password { get; set; }

      
    }



}