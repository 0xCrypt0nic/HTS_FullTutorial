using System;
using System.Runtime.Serialization;

namespace TPCalculatrice
{
    public class OperateurNonReconnuException : Exception
    {
        public string Operateur { get; set; } = "";

        public OperateurNonReconnuException(string ope)
            : base($"L'opérateur {ope} n'est pas reconnu")
        {
            Operateur = ope;
        }
    }
}
