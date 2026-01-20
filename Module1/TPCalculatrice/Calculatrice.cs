using System;

namespace TPCalculatrice
{
    public class Calculatrice
    {
        public int OperG { get; set; }
        public int OperD { get; set; }
        public int Resultat { get; set; }


        /// <summary>
        /// Méthode pour Additionner deux entiers.
        /// </summary>
        /// <param name="OperG">Premier nombre (entier)</param>
        /// <param name="OperD">Deuxième nombre (entier)</param>
        /// <returns>Résultat de l'addition</returns>
        public void Addition(int OperG, int OperD) => Resultat = OperG + OperD;
        public void Soustraction(int OperG, int OperD) => Resultat = OperG - OperD;
        public void Multiplication(int OperG, int OperD) => Resultat = OperG * OperD;
        public void Division(int OperG, int OperD)
        {
            Resultat = OperD == 0 ? 0 : OperG / OperD;
        }
        public void Modulo(int OperG, int OperD) => Resultat = OperG % OperD;
    }
}
