public class Individuo
{
    public string Nome { get; set; }
    public float Altura { get; set; }
    public float Peso { get; set; }
    public double IMC { get => Peso / (Altura * Altura); }

    public string Classificacao
    {
        get {
            if(IMC < 18.5)
            {
                return "Abaixo do Peso";
            }
            else if(IMC <= 24.9)
            {
                return "Peso Normal";
            }
            else if(IMC <= 29.9)
            {
                return "Sobrepeso";
            }
            else if(IMC <= 34.9)
            {
                return "Obesidade Grau I";
            }
            else if(IMC <= 39.9)
            {
                return "Obesidade Grau II";
            }
            else
            {
                return "Obesidade Grau III ";
            }
        }
    }

    public double PesoIdeal
    { 
        get {
            if(IMC < 18.5) return ((18.5 * Altura * Altura) - Peso);
            if(IMC > 24.9) return (Peso - (24.9 * Altura * Altura));
            else return 0;
        }
    }

    public Individuo()
    {
        Nome = "";
        Altura = 0;
        Peso = 0;
    }

    public Individuo(string nome, float altura, float peso)
    {
        Nome = nome;
        Altura = altura;
        Peso = peso;
    }
}