using System;

namespace Desafio_Aula_18._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero2;
            int numero1;
            int numero3;

            Console.WriteLine("Série de Fibonacci \n Calculo da série de Fibonacci até que o número seja maior que 500");
            
            numero1=1;
            Console.WriteLine($"{numero1}");
            numero2=1;
            Console.WriteLine($"{numero2}");
            numero3 = numero1+numero2;
             Console.WriteLine($"{numero3}");
           
           for (var i = 1; i <= 500; i=numero3)
           {   
               numero2=numero1; 
               numero1=numero3;
               numero3=numero2+numero1;
               Console.WriteLine($"{numero3}"); 
           }  
           
        }
    }
}
