using System;
using System.Globalization;

namespace CSharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            EntradaDadosP2Exercicio();
        }

        static void EntradaDadosP1() {

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            string[] v = Console.ReadLine().Split(' ');

            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine("Frase: " + frase);
            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);
            Console.WriteLine("z: " + z);
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
            Console.WriteLine("c: " + c);
            Console.ReadLine();
        }

        static void EntradaDadosP2()
        {
            int n1 =  int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//usar o ponto como separador
            string[] s = Console.ReadLine().Split(' ');

            string nome = s[0];
            char sexo = char.Parse(s[1]);
            int idade = int.Parse(s[2]);
            double altura = double.Parse(s[3], CultureInfo.InvariantCulture); 
            Console.WriteLine("Você digitou: ");
            Console.WriteLine("n1: " + n1);
            Console.WriteLine("ch: " + ch);
            Console.WriteLine("n2: " + n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("nome: " + nome);
            Console.WriteLine("sexo: " + sexo);
            Console.WriteLine("idade: " + idade);
            Console.WriteLine("altura: " + altura);

            Console.ReadLine();
        }

        static void EntradaDadosP2Exercicio()
        {
            Console.WriteLine("Informe seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe seu último nome, idade e altura (mesma linha):");
            string[] v = Console.ReadLine().Split(' ');

            string ultimoNome = v[0];
            int idade = int.Parse(v[1]);
            double altura = double.Parse(v[2], CultureInfo.InvariantCulture);


            Console.WriteLine("Você digitou: ");
            Console.WriteLine("nome: " + nome);
            Console.WriteLine("quartos: " + quartos);
            Console.WriteLine("preco: " + preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("ultimo nome: " + ultimoNome);
            Console.WriteLine("idade: " + idade);
            Console.WriteLine("altura: " + altura.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }

    }
}
