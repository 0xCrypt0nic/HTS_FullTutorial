using System;

namespace TPCalculatrice.Operations
{
    public class Division : Operation
    {
        public Division(int operandeG, int operandeD)
            : base(operandeG, operandeD)
        {
        }

        public void Executer()
        {
            Resultat = OperandeGauche / OperandeDroite;
        }
    }
}
