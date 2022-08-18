using Microsoft.AspNetCore.Mvc;
using MVCBasics.Models;
using System.ComponentModel;
using System.Xml.Linq;

namespace MVCBasics.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult FeverCheck()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FeverCheck(double temp, string scale)
        {
            ViewBag.Temp = temp;
            ViewBag.Scale = scale;

            temp = (scale == "fahrenheit") ? Doctor.FahrenheitToCelsius(temp) : temp;

            ViewBag.Message = Doctor.CheckFever(temp);
            ViewBag.Color = Doctor.GetTemperatureColor(temp);

            return View();
        }
    }
}
