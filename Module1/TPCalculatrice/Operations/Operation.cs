using System;

namespace TPCalculatrice.Operations
{
    public class Operation
    {
        public int OperandeGauche { get; set; }
        public int OperandeDroite { get; set; }

        public int Resultat { get; set; }

        public Operation(int operandeG, int operandeD)
        {
            OperandeGauche = operandeG;
            OperandeDroite = operandeD;
        }
    }
}
