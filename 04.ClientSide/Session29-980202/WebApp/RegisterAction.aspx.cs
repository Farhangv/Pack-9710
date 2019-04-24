using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp.Helpers;

namespace WebApp
{
    public partial class RegisterAction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["type"] == "newuser")
            {
                Student student = new Student()
                {
                    Name = Request.Form["name"],
                    Family = Request.Form["family"],
                    Age = int.Parse(Request.Form["age"]),
                    Courses = Request.Form["course"],
                    Degree = Request.Form["degree"],
                    Description = Request.Form["description"],
                    Email = Request.Form["email"],
                    Gender = Request.Form["gender"][0].ToString(),
                    Password = HashHelper.ToSha512Hash(Request.Form["password"])
                };

                var postedPhoto = Request.Files["photo"];
                var photoFileName = $"{Guid.NewGuid().ToString()}{Path.GetExtension(postedPhoto.FileName).ToLower()}";
                postedPhoto.SaveAs(Server.MapPath($"~/Photos/{photoFileName}"));
                student.PhotoFilePath = photoFileName;
                UniversityModel ctx = new UniversityModel();
                ctx.Students.Add(student);
                ctx.SaveChanges();
                resultMessage.InnerText = "ثبت کاربر با موفقیت انجام شد";
            }
        }
    }
}