using System;
using TPCalculatrice.Operations;

namespace TPCalculatrice
{
    public class Calculatrice
    {
        public Operation Operation { get; }

        public int Resultat => Operation.Resultat;

        public Calculatrice(Operation operation)
        {
            Operation = operation;
        }

        public void Executer()
        {
            if (Operation is Addition o)
            {
                o.Executer();
            }
            else if (Operation is Soustraction s)
            {
                s.Executer();
            }
            else if (Operation is Multiplication m)
            {
                m.Executer();
            }
            else if (Operation is Division d)
            {
                d.Executer();
            }
            else if (Operation is Modulo mo)
            {
                mo.Executer();
            }
            else
            {
                Console.WriteLine("Operation non reconnue");
            }
        }
    }
}
