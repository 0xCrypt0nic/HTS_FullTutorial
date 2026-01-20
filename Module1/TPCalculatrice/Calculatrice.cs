using System;

namespace TPCalculatrice
{
    public class Calculatrice
    {
        /// <summary>
        /// Méthode pour Additionner deux entiers.
        /// </summary>
        /// <param name="a">Premier nombre (entier)</param>
        /// <param name="b">Deuxième nombre (entier)</param>
        /// <returns>Résultat de l'addition</returns>
        public int Addition(int a, int b) => a + b;
        public int Soustraction(int a, int b) => a - b;
        public int Multiplication(int a, int b) => a * b;
        public int Division(int a, int b)
        {
            return b == 0 ? 0 : a / b;
        }
        public int Modulo(int a, int b) => a % b;
    }
}
