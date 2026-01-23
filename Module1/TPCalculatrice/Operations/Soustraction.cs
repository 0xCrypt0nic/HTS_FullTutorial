using System;

namespace TPCalculatrice.Operations
{
    public class Soustraction : Operation
    {
        public Soustraction(int operandeG, int operandeD)
            : base(operandeG, operandeD)
        {
        }

        public override void Executer()
        {
            Resultat = OperandeGauche - OperandeDroite;
        }

        public override string ToString() => $"{OperandeGauche} - {OperandeDroite} = {Resultat}";
    }
}
