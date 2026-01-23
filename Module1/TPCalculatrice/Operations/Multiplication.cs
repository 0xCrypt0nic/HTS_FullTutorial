using System;

namespace TPCalculatrice.Operations
{
    public class Multiplication : Operation
    {
        public Multiplication(int operandeG, int operandeD)
            : base(operandeG, operandeD)
        {
        }

        public override void Executer()
        {
            Resultat = OperandeGauche * OperandeDroite;
        }

        public override string ToString() => $"{OperandeGauche} * {OperandeDroite} = {Resultat}";
    }
}
