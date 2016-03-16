using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

        [Required]
        public string SelectedBandAColor { get; set; }
        [Required]
        public string SelectedBandBColor { get; set; }
        [Required]
        public string SelectedBandCColor { get; set; }
        [Required]
        public string SelectedBandDColor { get; set; }

        public decimal? Result { get; set; }
        public decimal? Tolerance { get; set; }
    }
}