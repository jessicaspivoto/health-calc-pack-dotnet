using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_calc_dotnet_pack.Interfaces
{
    public interface IBmi
    {
        double Calc(double height, double weight);
        string GetImcCategory(double imc);
        bool IsValidData(double height, double weight);
    }
}
