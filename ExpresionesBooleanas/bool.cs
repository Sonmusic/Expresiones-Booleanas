using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpresionesBooleanas
{
    public class Expresion
    {
        public string texto;
        public Expresion(string text)
        {
            texto = text;
        }
        public int CountHowManyVariables()
        {
            List<string> list = texto.Split(new[] { '&', ' ', '|', '(', ')','*' }, StringSplitOptions.RemoveEmptyEntries).ToList();
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
            if (Expresion == null)
            {
                throw new InvalidOperationException();
            }
            return Expresion.Count;
        }

        public string TablaBooleana()
        {
            if(CountHowManyVariables() == 1)
            {
                return "|1|\n|0|";
            }
            else if(CountHowManyVariables() == 2)
            {
                return "|1| |1|\n|1| |0|\n|0| |1|\n|0| |0|";
            }
            else
            {
                return "|1| |1| |1|\n|1| |1| |0|\n|1| |0| |1|\n|1| |0| |0|\n|0| |1| |1|\n|0| |1| |0|\n|0| |0| |1|\n|0| |0| |0|\n";
            }
        }
        
    }
}
