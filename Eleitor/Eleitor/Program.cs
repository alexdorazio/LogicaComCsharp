using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.Write("Digite sua idade: ");
            // quando for Numeracao usar esse comando = idade = int.parse(Console.ReadLine());
            idade = int.Parse(Console.ReadLine());

            if (idade < 16)
            {
                Console.Write("Não eleitor");
            }


            else if (idade >= 18 && idade < 65)
            {
                Console.Write("Eleitor obrigatorio");
            }
            else
            {
                Console.Write("Eleitor facultativo");
            }
        }
    }
}


        
   

