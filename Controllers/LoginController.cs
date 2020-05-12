using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using System.Text;
using System.Security.Cryptography;

namespace HIMS_Web.Controllers
{
    public class LoginController : Controller
    {
        public String 用户名 { get; set; }

        public IActionResult Index()
        {
            return View("Login");
        }
        public IActionResult Usercheck(String id, String pwd)
        {
            String Encrypted_pwd = GetHashString(pwd);

            SqlConnection cn = new SqlConnection("Server=localhost;uid=sa;pwd=root;database=Pro;Persist Security info=true;");
            SqlCommand sql = new SqlCommand("Select * from Users where id=" + id + ";")
            {

                Connection = cn
            };
       
            cn.Open();
            SqlDataReader reader = sql.ExecuteReader();

            reader.Read();
            if (reader.HasRows)
            {
                String encrypted = reader.GetString(2).ToUpper();
                Console.WriteLine("2:{0}",reader.GetString(2));
                if (encrypted == Encrypted_pwd)
                {
                    Set_Cookie(reader.GetString(1), 600);
                    cn.Close();
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewData["结果"] = "密码或用户名错误，请重试!";
                    return View("Login");
                }
            }
            else
            {
                ViewData["结果"] = "密码或ID错误，请重试!";
                return View("Login");
            }


        }


        public void Set_Cookie(String 用户名, int? expireTime)
        {
            CookieOptions option = new CookieOptions();
            if (expireTime.HasValue)
                option.Expires = DateTime.Now.AddMinutes(expireTime.Value);
            else
                option.Expires = DateTime.Now.AddMilliseconds(10);

            Response.Cookies.Append("name", 用户名, option);

        }

        public static string GetHashString(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(input))
                sb.Append(b.ToString("X2"));
            return sb.ToString();
        }

        private static Byte[] GetHash(string input)
        {
            using HashAlgorithm algorithm = MD5.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
        }

    }
}