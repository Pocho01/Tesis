using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD1.Models;

namespace CRUD1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Autherize(CRUD1.Models.User userModel)
        {
            using (ElManabaEntities db = new ElManabaEntities()){
                var userDetails = db.Users.Where(x => x.EmaisAddress == userModel.EmaisAddress && x.Password == userModel.Password).FirstOrDefault();
                if(userDetails == null)
                {
                    userModel.LoginErrorMessage = "Email o contraseña inválida.";
                    return View("Index", userModel);
                }
                else
                {
                    Session["userID"] = userDetails.IdUser;
                    Session["Name"] = userDetails.Name;
                    return RedirectToAction("Index", "Home");
                }
            }
        }
        public ActionResult LogOut()
        {
            int userID = (int)Session["userID"];
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}