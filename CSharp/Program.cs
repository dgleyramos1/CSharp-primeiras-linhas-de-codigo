using System;
using CSharp;
using Interface;
using Enum;

namespace CSharp
{
   class Program
    {
        public static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Dgley Ramos";
            pessoa.Idade = 27;
            pessoa.Estado = "Paraiba";

            Console.WriteLine("Nome: " + pessoa.Nome + "\n" + "Idade: " + pessoa.Idade + "\n" + "Estado: " + pessoa.Estado + "\n");

            Animal animal = new Animal();
            animal.Nome = "Jubileu";
            animal.NomeDono = "Ramos";
            animal.Especie = "Caramelo";

            Console.WriteLine("Nome:" + animal.Nome + "\n" + "Nome do Dono:" + animal.NomeDono + "\n" + "Especie:" + animal.Especie + "\n");


            Pessoas personagem = Pessoas.Gustavo;

            Console.WriteLine(personagem);


        }
    }
}