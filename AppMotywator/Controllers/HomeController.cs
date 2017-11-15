using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppMotywator.Algorithms;
using AppMotywator.Models;

namespace AppMotywator.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index(UserInformationModel model)
        {
            CountCalories calories = new CountCalories();
            var result = calories.Calculate(model);
            //var bmi = Math.Round(calories.CalculateBMI(data.UserInformationModelRepo), 1);
            //var userBmiInfo = calories.interpreteBMI(bmi);
            //data.UserBmiModel.Bmi = bmi;
            //data.UserBmiModel.UserBmiInfo = userBmiInfo;

            //return View(data.UserBmiModel);
            ViewBag.Message = "Your contact page." + result;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact with us!";

            return View();
        }
    }
}