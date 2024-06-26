using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FattyCalc.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class BMI
    {
        private float result;
        public float? Height { get; set; }
        public float? Weight { get; set; }
        public float? Result { 
            get 
            {
                return ((Weight / Height) / Height) * 10000;
            } 
        }

        public string ResultText
        {
            get
            {
                string template = "BMI: #";
                if (Result <= 16)
                {
                    return template.Replace("#", "Somalian Child");
                }
                else if (Result > 16 && Result <= 17)
                {
                    return template.Replace("#", "Slenderman");
                }
                else if (Result > 17 && Result <= 18.5)
                {
                    return template.Replace("#", "Stick Boi");
                }
                else if (Result > 18.5 && Result <= 25)
                {
                    return template.Replace("#", "Basic Bitch");
                }
                else if (Result > 25 && Result <= 30)
                {
                    return template.Replace("#", "Lil' Chonky");
                }
                else if (Result > 30 && Result <= 35)
                {
                    return template.Replace("#", "Thicccccy");
                }
                else if (Result > 35 && Result <= 40)
                {
                    return template.Replace("#", "Getting Fat Now....");
                }
                else
                {
                    return template.Replace("#", "Is That Death Knocking? Or Uber Eats?");
                }
            }
        }

    }
}
