
using JogodeRPG.src.Entities;

class Program
{
    static void Main(string[] args)
    {
        Knight hero = new Knight ("Arus", 23, "Knight");
        Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
        Ninja ninja = new Ninja("Wedge", 34, "Ninja");
        BlackWizard blackwizard = new BlackWizard("Topapa", 45, "Black Wizard");
       
       
         
         Console.WriteLine(wizard.Attack(1));
         Console.WriteLine(hero.Attack());
         Console.WriteLine(ninja.Attack());
         Console.WriteLine(blackwizard.Attack());

    }
}
