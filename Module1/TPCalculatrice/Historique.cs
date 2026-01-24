using System;
using TPCalculatrice.Operations;

namespace TPCalculatrice
{
    public static class Historique
    {
        public static List<IOperation> Operations { get; }
            = new();
    }
}
