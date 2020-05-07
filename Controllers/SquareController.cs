using System;
using Microsoft.AspNetCore.Mvc;

namespace SquareRootWeb.Controllers
{
    public class SquareController : Controller
    {
        [HttpGet]

        public ActionResult Root()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Root(string firstNumber, string secondNumber)
        {
            try
            {
                int numberOne = int.Parse(firstNumber);
                int numberTwo = int.Parse(secondNumber);

                double sq1 = Math.Sqrt(numberOne);
                double sq2 = Math.Sqrt (numberTwo);

                ViewBag.Result1 = sq1;
                ViewBag.Result2 = sq2;
                ViewBag.Result3 = numberOne;
                ViewBag.Result4 = numberTwo;
            }
            catch (System.Exception)
            {
                ViewBag.Error = "Error, enter only numbers";
            }
            return View();
        }
    }
}