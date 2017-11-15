using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppMotywator.Models;

namespace AppMotywator.Algorithms
{
    public class CountCalories
    {
        public double Calculate(UserInformationModel userInformationModel)
        {
            double result = 0.0;

            if (userInformationModel.Gender == 2) //woman
            {
                result = 655 + 9.6 * userInformationModel.Weight + 1.85 * userInformationModel.Height - 4.7 * userInformationModel.Age;
            }
            else //man
            {
                result = 66.5 + 13.7 * userInformationModel.Weight + 5 * userInformationModel.Height - 6.8 * userInformationModel.Age;
            }

            switch (userInformationModel.Lifestyle)
            {
                case 1:
                    //resultA *= 1;
                    break;
                case 2:
                    result = result * 1.2;
                    break;
                case 3:
                    result = result * 1.4;
                    break;
                case 4:
                    result = result * 1.6;
                    break;
                case 5:
                    result = result * 1.8;
                    break;
                case 6:
                    result = result * 2.0;
                    break;
            }


            switch (userInformationModel.Target)
            {
                case 1: // budowanie masy
                    switch (userInformationModel.BodyType)
                    {
                        case 1:     //Ektomorfik
                            result = result + 0.2 * result;
                            break;
                        case 2:     // Mezomorfik
                            result = result + 0.15 * result;
                            break;
                        case 3:     //Endomorfik
                            result = result + 0.1 * result;
                            break;
                    }
                    break;
                case 2:     // redukcja
                    switch (userInformationModel.BodyType)
                    {
                        case 1:     //Ektomorfik
                            result = result - 0.1 * result;
                            break;
                        case 2:     // Mezomorfik
                            result = result - 0.15 * result;
                            break;
                        case 3:     //Endomorfik
                            result = result - 0.2 * result;
                            break;
                    }
                    break;
            }
            return result;
        }

        public double CalculateBMI(UserInformationModel userInformationModel)
        {
            double result = 0.0;
            if (userInformationModel.Weight == 0 || userInformationModel.Height == 0)
                return 0;

            result = userInformationModel.Weight / (userInformationModel.Height * userInformationModel.Height / 100 / 100);

            return result;
        }

        public string interpreteBMI(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if (bmi < 25)
            {
                return "Desirable";
            }
            else if (bmi < 30)
            {
                return "Overweight";
            }
            else if (bmi < 35)
            {
                return "Obesity class I";
            }
            else if (bmi < 40)
            {
                return "Obesity class II";
            }
            else
            {
                return "Obesity class III";
            }

        }

    }
}