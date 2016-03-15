using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ResistorColorCodeCalculator.Models {
    public class CalculatorViewModel {

        [DisplayName ("Select Band A Color")]
        public List<string> BandAColors { get; set; }
        [DisplayName("Select Band B Color")]
        public List<string> BandBColors { get; set; }
        [DisplayName("Select Band C Color")]
        public List<string> BandCColors { get; set; }
        [DisplayName("Select Band D Color")]
        public List<string> BandDColors { get; set; }

        public string SelectedBandAColor { get; set; }
        public string SelectedBandBColor { get; set; }
        public string SelectedBandCColor { get; set; }
        public string SelectedBandDColor { get; set; }

        public int? Result { get; set; }
        public decimal? Tolerance { get; set; }
    }
}