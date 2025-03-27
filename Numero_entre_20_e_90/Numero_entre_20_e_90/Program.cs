using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_entre_20_e_90
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //Construa um algoritmo que indique se um número digitado está compreendido entre 20 e 90 ou não (20 e 90 não estão na faixa de valores).

            {
             int numero;

                Console.Write("Digite um numero entre 20 e 90: ");
             numero = int.Parse(Console.ReadLine());
              
             if(numero > 20 && numero < 90){
                    //&& =  "E"
                    // IF = "SE"
             Console.Write("este numero esta dentro do compreendido de 20 e 90 ");
    }
             else{
                    //else = senão
             Console.Write("O numero ", numero, "\nnão esta dentro do compreendido de 20 e 90");
    }



                }
            }











        }
    }

