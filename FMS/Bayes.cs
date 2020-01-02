using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMS
{
    class Bayes
    {
        public decimal ComputeWorthiness(decimal netincome,string UserClass,decimal monthly) {
            decimal ans = 0, Classper=0;
            Double per;
            switch (UserClass) {
                case "A":
                    per = 0.1;
                    Classper =(decimal)per;
                break;
                case "B":
                    per = 0.75;
                    Classper = (decimal)per;
                    break;
                case "C":
                    per = 0.5;
                    Classper = (decimal)per;
                    break;
                case "D":
                    per = 0.25;
                    Classper = (decimal)per;
                    break;
                default:
                    Classper = 0;
                    break;

            }
            decimal PH = netincome / monthly;
            decimal PEH1 = (PH + Classper) / 2;
            decimal PEH2 = (PEH1 / Classper) * PH;

            return PEH2;
        }


    }
}
