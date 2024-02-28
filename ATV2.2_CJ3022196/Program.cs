using System;

class Program
{

    static void Main ()
    {

        Console.WriteLine("Digite um número inteiro: ");
        int numero =
        Convert.ToInt32(Console.ReadLine());

        int resultado = (numero * 3 + 1) + (numero * 2 - 1);

        Console.WriteLine(" A soma do sucessor do triplo com o antecessor do dobro é: " + resultado);
    }
}