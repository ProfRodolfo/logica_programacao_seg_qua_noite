﻿namespace ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ex12. Contagem de Números Ímpares
            Escreva um programa que imprima todos os números ímpar de 1 a 20 utilizando um laço `while`. */

            int i = 1;

            while (i <= 20)
            {
                Console.WriteLine(i);
                i+=2;
            }

        }
    }
}
