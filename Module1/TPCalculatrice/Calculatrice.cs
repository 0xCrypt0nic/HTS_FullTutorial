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
            Operation.Executer();
        }
    }
}
