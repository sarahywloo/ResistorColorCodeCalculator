using ResistorColorCodeCalculator.Logic;
using ResistorColorCodeCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResistorColorCodeCalculator.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.Title = "Home Page";

            //creating an instance of the view model
            CalculatorViewModel vm = new CalculatorViewModel();

            vm.BandAColors = new List<string> { "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Violet", "Gray", "White" };
            vm.BandBColors = new List<string> { "Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Violet", "Gray", "White" };
            vm.BandCColors = new List<string> { "Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Violet", "Gray", "White", "Gold", "Silver" };
            vm.BandDColors = new List<string> { "Brown", "Red", "Yellow", "Green", "Blue", "Violet", "Gray", "Gold", "Silver", "None" };

            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(CalculatorViewModel vm) {

            var calculateOhm = new Calculator();
            vm.Result = calculateOhm.CalculatorOhmValue(vm.SelectedBandAColor, vm.SelectedBandBColor, vm.SelectedBandCColor, vm.SelectedBandDColor);

            vm.Tolerance = calculateOhm.GetTolerance(vm.SelectedBandDColor);

            vm.BandAColors = new List<string> { "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Violet", "Gray", "White" };
            vm.BandBColors = new List<string> { "Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Violet", "Gray", "White" };
            vm.BandCColors = new List<string> { "Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Violet", "Gray", "White", "Gold", "Silver" };
            vm.BandDColors = new List<string> { "Brown", "Red", "Yellow", "Green", "Blue", "Violet", "Gray", "Gold", "Silver", "None" };

            return View(vm);
        }
    }
}
