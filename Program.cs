Individuo i = new Individuo();

Console.WriteLine("Qual o seu nome?");
i.Nome = Console.ReadLine();

Console.WriteLine("\nQual a sua altura em metros? Ex: 1,65");
i.Altura = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("\nQual o seu peso em kg? Ex: 57,4");
i.Peso = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("------------------------");
Console.WriteLine("Nome: {0}", i.Nome);
Console.WriteLine("Altura: {0}m", i.Altura);
Console.WriteLine("Peso: {0}kg", i.Peso);
Console.WriteLine("IMC: {0}", Math.Round(i.IMC, 2));
Console.WriteLine("Classificação: {0}", i.Classificacao);

if(i.IMC < 18.5)
{
    Console.WriteLine("\nVocê precisa ganhar {0}kg para chegar ao seu peso ideal.", Math.Round(i.PesoIdeal, 2));
}
else if(i.IMC > 24.9)
{
    Console.WriteLine("\nVocê precisa perder {0}kg para chegar ao seu peso ideal.", Math.Round(i.PesoIdeal, 2));
}