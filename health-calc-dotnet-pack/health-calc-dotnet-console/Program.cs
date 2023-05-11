// See https://aka.ms/new-console-template for more information

using health_calc_dotnet_pack;

var imc = new Imc();
var result = imc.Calc(1.80, 97.0);
var category = imc.GetImcCategory(result);

Console.WriteLine($"Seu IMC é: {result} e a classificação é {category}");

