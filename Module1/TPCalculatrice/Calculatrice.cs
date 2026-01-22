using System;
using TPCalculatrice.Operations;

namespace TPCalculatrice
{
    public class Calculatrice
    {
        public IOperation Operation { get; }

        public int Resultat => Operation.Resultat;

        public Calculatrice(IOperation operation)
        {
            Operation = operation;
        }

        public void Executer()
        {
            Operation.Executer();
        }
    }
}
