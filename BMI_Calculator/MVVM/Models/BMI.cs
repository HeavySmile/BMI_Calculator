using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class BMI
    {
        private const int bmi_constant = 10000;
        
        private float _height;
        private float _weight;
        private float _result;
        private string _resultText;

        public float Height 
        { 
            get => _height; 
            set 
            {
                _height = value;
            }
        }
        public float Weight 
        {
            get => _weight;
            set
            {
                _weight = value;
            }
        }
        public float Result 
        { 
            get
            {
                return ((_weight / _height) / _height) * bmi_constant;
            }
            set
            {
                _result = value;
            }
        }

        public string ResultText 
        {
            get
            {
                string basis = "BMI: ";
                string fullText;
                if (Result <= 16) fullText = basis + "Severe Thinness";
                else if (Result > 16 && Result <= 17) fullText = basis + "Moderate Thinness";
                else if (Result > 17 && Result <= 18.5) fullText = basis + "Mild Thinness";
                else if (Result > 18.5 && Result <= 25) fullText = basis + "Normal";
                else if (Result > 25 && Result <= 30) fullText = basis + "Overweight";
                else if (Result > 30 && Result <= 35) fullText = basis + "Obese Class I";
                else if (Result > 35 && Result <= 40) fullText = basis + "Obese Class II";
                else fullText = basis + "Obese Class III";

                return fullText;
            }
        }
    }
}
