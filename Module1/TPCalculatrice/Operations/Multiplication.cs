using System;

namespace TPCalculatrice.Operations
{
    public class Multiplication : Operation
    {
        public Multiplication(int operandeG, int operandeD)
            : base(operandeG, operandeD)
        {
        }

        public void Executer()
        {
            Resultat = OperandeGauche * OperandeDroite;
        }
    }
}
