namespace Delegates
{
    using System;

    public class MoneyPrinter
    {
        // Définition de la déléguée ShowMoney
        public delegate void ShowMoney(decimal amount);

        // Méthode d'affichage en dollars
        public static void ShowInDollars(decimal amount)
        {
            Console.WriteLine($"Amount in dollars: ${amount}");
        }

        // Méthode d'affichage en euros
        public static void ShowInEuros(decimal amount)
        {
            Console.WriteLine($"Amount in euros: €{amount}");
        }

        // Méthode pour afficher le montant d'argent en utilisant la déléguée fournie
        public static void DisplayMoney(decimal amount, ShowMoney displayDelegate)
        {
            displayDelegate(amount);
        }

        public static void Main(string[] args)
        {
            decimal amount = 100.50m;

            // Utilisation de la déléguée ShowMoney pour afficher le montant en dollars
            ShowMoney dollarDelegate = new ShowMoney(ShowInDollars);
            DisplayMoney(amount, dollarDelegate);

            // Utilisation de la même déléguée pour afficher le montant en euros
            ShowMoney euroDelegate = new ShowMoney(ShowInEuros);
            DisplayMoney(amount, euroDelegate);
        }
    }

}
