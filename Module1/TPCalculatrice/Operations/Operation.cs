using System;

namespace TPCalculatrice.Operations
{
    public abstract class Operation
    {
        // protected : ne peut être visible que dans cette classe et les classes filles.
        protected int OperandeGauche { get; set; }
        protected int OperandeDroite { get; set; }

        public int Resultat { get; protected set; }

        protected Operation(int operandeG, int operandeD)
        {
            OperandeGauche = operandeG;
            OperandeDroite = operandeD;
        }

        public abstract void Executer();
    }
}
