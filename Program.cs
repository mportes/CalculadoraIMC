﻿using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("\nQual a sua altura? Ex: 1,65");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nQual o seu peso em Kg? Ex: 57,4");
            float peso = Convert.ToSingle(Console.ReadLine());

            double imc = Math.Round((peso / (altura * altura)), 2);

            Console.WriteLine("\n{0}, sua altura é {1} e seu peso é {2}", nome, altura, peso);
            Console.WriteLine("Seu IMC é {0}", imc);
            Console.Write("Classificação: ");

            if(imc < 18.5)
                Console.WriteLine("Abaixo do Peso");

            else if(imc >= 18.5 && imc <= 24.9)
                Console.WriteLine("Peso Normal");

            else if(imc >= 25 && imc <= 29.9)
                Console.WriteLine("Sobrepeso");

            else if(imc >= 30 && imc <= 34.9)
                Console.WriteLine("Obesidade Grau I");

            else if(imc >= 35 && imc <= 39.9)
                Console.WriteLine("Obesidade Grau II");

            else
                Console.WriteLine("Obesidade Grau III ");
        }
    }
}