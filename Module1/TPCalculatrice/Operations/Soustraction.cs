using System;

namespace TPCalculatrice.Operations
{
    public class Soustraction : Operation
    {
        public Soustraction(int operandeG, int operandeD)
            : base(operandeG, operandeD)
        {
        }

        public void Executer()
        {
            Resultat = OperandeGauche - OperandeDroite;
        }
    }
}
