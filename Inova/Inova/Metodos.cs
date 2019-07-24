using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Inova
{
    public class Metodos
    {
        //1 - Utilizando LINQ, elabore um método que defina se o seguinte array contém somente números ímpares e demonstre o resultado no console:
        public static void VerificaImpares()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Verificando Nº impares");
            Console.WriteLine("-------------------------------------------------");
            int[] numeros = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };

            var CountQuery = (
                from num in numeros
                where (num % 2) == 0
                select num);

            if (CountQuery.Count() > 0)
            {
                Console.WriteLine("O conjunto não é composto apenas por números impares, " +
                    "pois foram encontrados os seguintes Nº pares: ");
                foreach (int num in CountQuery)
                {

                    Console.WriteLine("{0,1} ", num);
                }
            }
            else
            {
                Console.WriteLine("O conjunto é totalmente impar.");
            }
        }

        //2 - Utilizando LINQ, elabore um método que traga somente os números do primeiro array que não estejam contidos no segundo array e 
        //demonstre o resultado no console:

        public static void VerificaConjuntos()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Mostrando Nº diferentes");
            Console.WriteLine("-------------------------------------------------");

            int[] primeiroArray = { 1, 3, 7, 29, 42, 98, 234, 93 };
            int[] segundoArray = { 4, 6, 93, 7, 55, 32, 3 };

            var NotExists = primeiroArray.Where(x => !segundoArray.Contains(x))
                .OrderBy(x => x)
                .ToList();


            foreach (int nums in NotExists)
            {

                Console.WriteLine(nums);
            }
            Console.Read();
        }
     }
}