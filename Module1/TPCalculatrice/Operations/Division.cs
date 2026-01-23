using System;

namespace TPCalculatrice.Operations
{
    public class Division : Operation
    {
        public Division(int operandeG, int operandeD)
            : base(operandeG, operandeD)
        {
        }

        public override void Executer()
        {
            Resultat = OperandeGauche / OperandeDroite;
        }

        public override string ToString() => $"{OperandeGauche} / {OperandeDroite} = {Resultat}";
    }
}
