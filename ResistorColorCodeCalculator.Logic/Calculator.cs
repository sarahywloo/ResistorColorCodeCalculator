using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistorColorCodeCalculator.Logic {
    public class Calculator : IOhmValueCalculator {

        private Dictionary<string, ColValue> BandAList;
        private Dictionary<string, ColValue> BandBList;
        private Dictionary<string, ColValue> BandCList;
        private Dictionary<string, ColValue> BandDList;

        public Calculator () {
            BandAList = new Dictionary<string, ColValue>();
            BandBList = new Dictionary<string, ColValue>();
            BandCList = new Dictionary<string, ColValue>();
            BandDList = new Dictionary<string, ColValue>();

            //BandAList colors & values
            BandAList.Add("Brown", new ColValue { Color = "Brown", Value = "1" });
            BandAList.Add("Red", new ColValue { Color = "Red", Value = "2" });
            BandAList.Add("Orange", new ColValue { Color = "Orange", Value = "3" });
            BandAList.Add("Yellow", new ColValue { Color = "Yellow", Value = "4" });
            BandAList.Add("Green", new ColValue { Color = "Green", Value = "5" });
            BandAList.Add("Blue", new ColValue { Color = "Blue", Value = "6" });
            BandAList.Add("Violet", new ColValue { Color = "Violet", Value = "7" });
            BandAList.Add("Gray", new ColValue { Color = "Gray", Value = "8" });
            BandAList.Add("White", new ColValue { Color = "White", Value = "9" });

            //BandBList colors & values
            BandBList.Add("Black", new ColValue { Color = "Black", Value = "0" });
            BandBList.Add("Brown", new ColValue { Color = "Brown", Value = "1" });
            BandBList.Add("Red", new ColValue { Color = "Red", Value = "2" });
            BandBList.Add("Orange", new ColValue { Color = "Orange", Value = "3" });
            BandBList.Add("Yellow", new ColValue { Color = "Yellow", Value = "4" });
            BandBList.Add("Green", new ColValue { Color = "Green", Value = "5" });
            BandBList.Add("Blue", new ColValue { Color = "Blue", Value = "6" });
            BandBList.Add("Violet", new ColValue { Color = "Violet", Value = "7" });
            BandBList.Add("Gray", new ColValue { Color = "Gray", Value = "8" });
            BandBList.Add("White", new ColValue { Color = "White", Value = "9" });

            //BandCList colors & values
            BandCList.Add("Black", new ColValue { Color = "Black", Value = "1" });
            BandCList.Add("Brown", new ColValue { Color = "Brown", Value = "10" });
            BandCList.Add("Red", new ColValue { Color = "Red", Value = "100" });
            BandCList.Add("Orange", new ColValue { Color = "Orange", Value = "1000" });
            BandCList.Add("Yellow", new ColValue { Color = "Yellow", Value = "10000" });
            BandCList.Add("Green", new ColValue { Color = "Green", Value = "100000" });
            BandCList.Add("Blue", new ColValue { Color = "Blue", Value = "1000000" });
            BandCList.Add("Violet", new ColValue { Color = "Violet", Value = "10000000" });
            BandCList.Add("Gray", new ColValue { Color = "Gray", Value = "100000000" });
            BandCList.Add("White", new ColValue { Color = "White", Value = "1000000000" });
            BandCList.Add("Gold", new ColValue { Color = "Gold", Value = "0.1" });
            BandCList.Add("Silver", new ColValue { Color = "Silver", Value = "0.01" });

            //BandDList colors & values
            BandDList.Add("Brown", new ColValue { Color = "Brown", Value = "1" });
            BandDList.Add("Red", new ColValue { Color = "Red", Value = "2" });
            BandDList.Add("Yellow", new ColValue { Color = "Yellow", Value = "5" });
            BandDList.Add("Green", new ColValue { Color = "Green", Value = "0.5" });
            BandDList.Add("Blue", new ColValue { Color = "Blue", Value = "0.25" });
            BandDList.Add("Violet", new ColValue { Color = "Violet", Value = "0.1" });
            BandDList.Add("Gray", new ColValue { Color = "Gray", Value = "0.05" });
            BandDList.Add("Gold", new ColValue { Color = "Gold", Value = "5" });
            BandDList.Add("Silver", new ColValue { Color = "Silver", Value = "10" });
            BandDList.Add("None", new ColValue { Color = "None", Value = "20" });
        }


    public decimal CalculatorOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor) {

        if (!ValidInput(bandAColor, bandBColor, bandCColor, bandDColor)) {

            throw new ArgumentException();
        }

            var aCol = BandAList[bandAColor];
            var bCol = BandBList[bandBColor];
            var cCol = BandCList[bandCColor];

            var result = int.Parse(aCol.Value + bCol.Value) * decimal.Parse(cCol.Value);

            return result;

    }

        public bool ValidInput(string bandAColor, string bandBColor, string bandCColor, string bandDColor) {
            return BandAList.ContainsKey(bandAColor) && BandBList.ContainsKey(bandBColor) && BandCList.ContainsKey(bandCColor) && BandDList.ContainsKey(bandDColor);
        }
        
        //Tolerance is separated from the resistor 'value' calculation because it represents a range
        public decimal GetTolerance (string bandDColor) {

            var dCol = BandDList[bandDColor];
            return decimal.Parse(dCol.Value);
        }
    }
}
