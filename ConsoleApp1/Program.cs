using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string texto = "(A && B) || A";
            //List<string> list= texto.Split(new[] { '&', ' ', '|', '(', ')' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            //List<string> Expresion = new List<string>();
            //foreach (string Variable in list)
            //{
            //    var VariableToUpper = Variable.ToUpper();
            //    if (Expresion.Contains(VariableToUpper))
            //    {

            //    }
            //    else
            //    {
            //        Expresion.Add(VariableToUpper);
            //    }
            //}
            //Console.WriteLine(Expresion.Count());
            //foreach (var x in Expresion)
            //{
            //    Console.WriteLine(x);
            //}
            //Console.WriteLine("|1| |1|\n|1| |0|\n|0| |1|\n|0| |0|");
            string texto = "(A || B) && (*A && B)";
            List<string> list = texto.Split(new[] { '&', ' ', '|', '(', ')', '*' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> Expresion = new List<string>();
            foreach (string Variable in list)
            {
                var VariableToUpper = Variable.ToUpper();
                if (Expresion.Contains(VariableToUpper))
                {

                }
                else
                {
                    Expresion.Add(VariableToUpper);
                }
            }
            foreach (var x in Expresion)
            {
                Console.WriteLine(x);
            }
        }
    }
}
