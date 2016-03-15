using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistorColorCodeCalculator.Logic {
    class ColDefinition {
        public enum BandColor {
            Black,
            Brown,
            Red,
            Orange,
            Yellow,
            Green,
            Blue,
            Violet,
            Gray,
            White,
            Gold,
            Silver,
            None
        }

        public BandColor Color { get; set; }
        public int Value { get; }
        public decimal Multiplier { get; }
        public decimal Tolerance { get; }

        public ColDefinition(BandColor color, int value, decimal multiplier, decimal tolerance) {
            Color = color;
            Value = value;
            Multiplier = multiplier;
            Tolerance = tolerance;
        }
    }
}
