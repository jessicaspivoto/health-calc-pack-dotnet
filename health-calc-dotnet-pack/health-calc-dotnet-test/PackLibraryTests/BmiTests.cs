using health_calc_dotnet_pack;
using health_calc_dotnet_pack.Interfaces;

namespace health_calc_dotnet_test.PackLibraryTests
{
    public class BmiTests
    {
        [Fact]
        public void CalculateImc_whenValidInput_thenReturnIndex()
        {
            IBmi imc = new Bmi();
            double height = 1.68;
            double weight = 72.0;
            double expetedImc = 25.5;

            var result = imc.Calc(height, weight);

            Assert.Equal(expetedImc, result);
        }

        [Fact]
        public void ValidateImc_whenInvalidInput_thenReturnFalse()
        {
            IBmi imc = new Bmi();
            double height = 10.68;
            double weight = 72.0;
            
            var result = imc.IsValidData(height, weight);

            Assert.False(result);
        }

        [Fact]
        public void ValidateImc_whenValidInput_thenReturnTrue()
        {
            IBmi imc = new Bmi();
            double height = 1.80;
            double weight = 97.0;

            var result = imc.IsValidData(height, weight);

            Assert.True(result);
        }

        [Fact]
        public void CategorizeSlimness_whenValidInput_ThenReturnImcSlimnessCategory()
        {
            IBmi imc = new Bmi();
            double valorIMC = 18.4;
            string expeted = "SLIMNESS";

            var result = imc.GetImcCategory(valorIMC);

            Assert.Equal(expeted, result);  
        }

        [Fact]
        public void CategorizeNormal_whenValidInput_ThenReturnImcNormalLim1Category()
        {
            IBmi imc = new Bmi();
            double valorIMC = 18.5;
            string expeted = "NORMAL";

            var result = imc.GetImcCategory(valorIMC);

            Assert.Equal(expeted, result);
        }

        [Fact]
        public void CategorizeNormal_whenValidInput_ThenReturnImcNormalLim2Category()
        {
            IBmi imc = new Bmi();
            double valorIMC = 24.9;
            string expeted = "NORMAL";

            var result = imc.GetImcCategory(valorIMC);

            Assert.Equal(expeted, result);
        }

        [Fact]
        public void CategorizeOverweight_whenValidInput_ThenReturnImcOverweightLim1Category()
        {
            IBmi imc = new Bmi();
            double valorIMC = 25.0;
            string expeted = "OVERWEIGHT";

            var result = imc.GetImcCategory(valorIMC);

            Assert.Equal(expeted, result);
        }

        [Fact]
        public void CategorizeOverweight_whenValidInput_ThenReturnImcOverweightLim2Category()
        {
            IBmi imc = new Bmi();
            double valorIMC = 29.9;
            string expeted = "OVERWEIGHT";

            var result = imc.GetImcCategory(valorIMC);

            Assert.Equal(expeted, result);
        }

        [Fact]
        public void CategorizeObesity_whenValidInput_ThenReturnImcObesityLim1Category()
        {
            IBmi imc = new Bmi();
            double valorIMC = 30.0;
            string expeted = "OBESITY";

            var result = imc.GetImcCategory(valorIMC);

            Assert.Equal(expeted, result);
        }

        [Fact]
        public void CategorizeObesity_whenValidInput_ThenReturnImcObesityLim2Category()
        {
            IBmi imc = new Bmi();
            double valorIMC = 39.9;
            string expeted = "OBESITY";

            var result = imc.GetImcCategory(valorIMC);

            Assert.Equal(expeted, result);
        }

        [Fact]
        public void CategorizeSeriousObesity_whenValidInput_ThenReturnImcSeriousObesityCategory()
        {
            IBmi imc = new Bmi();
            double valorIMC = 40.1;
            string expeted = "SERIOUS OBESITY";

            var result = imc.GetImcCategory(valorIMC);

            Assert.Equal(expeted, result);
        }

        [Fact]
        public void CategorizeUndefined_whenInvalidInput_ThenReturnUndefinedCategory()
        {
            IBmi imc = new Bmi();
            double valorIMC = 0.1;
            string expeted = "UNDEFINED";

            var result = imc.GetImcCategory(valorIMC);

            Assert.Equal(expeted, result);
        }
    }
}