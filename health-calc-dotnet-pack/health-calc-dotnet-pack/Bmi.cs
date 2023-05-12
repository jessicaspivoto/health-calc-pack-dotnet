using health_calc_dotnet_pack.Interfaces;

namespace health_calc_dotnet_pack
{
    public class Bmi : IBmi
    {
        public double Calc(double height, double weight)
        {
            return Math.Round(weight / (height * height),1);
        }

        public string GetImcCategory(double imc)
        {
           switch (imc)
            {
                case >= 15.0 and < 18.5:
                    return "SLIMNESS";
                case >= 18.5 and < 25.0:
                    return "NORMAL";
                case >= 25.0 and < 30.0:
                    return "OVERWEIGHT";
                case >= 30.0 and < 40.0:
                    return "OBESITY";
                case >=40.0:
                    return "SERIOUS OBESITY";
                default:
                    return "UNDEFINED";
            }
        }

        public bool IsValidData(double height, double weight)
        {
            return (height < 3.0 && weight <= 300.0);
        }
    }
}
