using System;

namespace TPCalculatrice.Operations
{
    public interface IOperation
    {
        void Executer();

        int Resultat { get; }
    }
}
