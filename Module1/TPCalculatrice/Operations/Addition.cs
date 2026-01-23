using System;

namespace TPCalculatrice.Operations
{
    public class Addition : Operation
    {
        public Addition(int operandeG, int operandeD)
            : base(operandeG, operandeD)
        {
        }

        public override void Executer()
        {
            if (OperandeDroite != 0)
            {
                Resultat = OperandeGauche + OperandeDroite;
            }
        }

        public override string ToString() => $"{OperandeGauche} + {OperandeDroite} = {Resultat}";
    }
}
