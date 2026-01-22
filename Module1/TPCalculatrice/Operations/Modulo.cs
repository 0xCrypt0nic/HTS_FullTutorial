using System;

namespace TPCalculatrice.Operations
{
    public class Modulo : Operation
    {
        public Modulo(int operandeG, int operandeD)
            : base(operandeG, operandeD)
        {

        }

        public override void Executer()
        {
            Resultat = OperandeGauche % OperandeDroite;
        }
    }
}
