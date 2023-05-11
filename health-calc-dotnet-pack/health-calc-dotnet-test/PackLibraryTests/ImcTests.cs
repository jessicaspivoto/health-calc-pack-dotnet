using health_calc_dotnet_pack;
using health_calc_dotnet_pack.Interfaces;

namespace health_calc_dotnet_test.PackLibraryTests
{
    public class ImcTests
    {
        [Fact]
        public void CalculateImc_whenValidInput_thenReturnIndex()
        {
            IImc imc = new Imc();
            double height = 1.68;
            double weight = 72.0;
            double expetedImc = 25.5;

            var result = imc.Calc(height, weight);

            Assert.Equal(expetedImc, result);
        }

        [Fact]
        public void ValidateImc_whenInvalidInput_thenReturnFalse()
        {
            IImc imc = new Imc();
            double height = 10.68;
            double weight = 72.0;
            
            var result = imc.IsValidData(height, weight);

            Assert.False(result);
        }

        [Fact]
        public void ValidateImc_whenValidInput_thenReturnTrue()
        {
            IImc imc = new Imc();
            double height = 1.80;
            double weight = 97.0;

            var result = imc.IsValidData(height, weight);

            Assert.True(result);
        }

        [Fact]
        public void whenValidInput_ThenReturnImcSlimnessCategory()
        {
            IImc imc = new Imc();
            double valorIMC = 18.4;
            string expeted = "SLIMNESS";

            var result = imc.GetImcCategory(valorIMC);

            Assert.Equal(expeted, result);  
        }

        [Fact]
        public void whenValidInput_ThenReturnImcNormalCategory_()
        {
            IImc imc = new Imc();
            double valorIMC = 24.8;
            string expeted = "NORMAL";

            var result = imc.GetImcCategory(valorIMC);

            Assert.Equal(expeted, result);
        }

        [Fact]
        public void whenValidInput_ThenReturnImcOverWeightCategory_()
        {
            IImc imc = new Imc();
            double valorIMC = 29.8;
            string expeted = "OVERWEIGHT";

            var result = imc.GetImcCategory(valorIMC);

            Assert.Equal(expeted, result);
        }


        [Fact]
        public void whenValidInput_ThenReturnImcObesityCategory_()
        {
            IImc imc = new Imc();
            double valorIMC = 39.8;
            string expeted = "OBESITY";

            var result = imc.GetImcCategory(valorIMC);

            Assert.Equal(expeted, result);
        }

        [Fact]
        public void whenValidInput_ThenReturnImcSeriousObesityCategory_()
        {
            IImc imc = new Imc();
            double valorIMC = 40.1;
            string expeted = "SERIOUS OBESITY";

            var result = imc.GetImcCategory(valorIMC);

            Assert.Equal(expeted, result);
        }
    }
}