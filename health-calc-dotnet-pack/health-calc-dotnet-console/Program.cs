// See https://aka.ms/new-console-template for more information

using health_calc_dotnet_pack;

internal class Program
{
    private static void Main(string[] args)
    {
        var imc = new Bmi();
        var result = imc.Calc(1.80, 97.0);
        var category = imc.GetImcCategory(result);

        Console.WriteLine($"Seu IMC é: {result} e a classificação é {category}");
    }
}