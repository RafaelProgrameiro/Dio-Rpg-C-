using Projeto_DIO.src.Entities;

Knight arus = new Knight("Arus", 12, "Knight");
Wizard jenica = new Wizard("Jenica", 20, "White Wizard");
Ninja wedge = new Ninja("Wedge", 18, "Ninja");
Wizard topapa = new Wizard("Topapa", 15, "Black Wizard");



arus.status();

jenica.status();

wedge.status();

topapa.status();


System.Console.WriteLine(arus.attack());
System.Console.WriteLine();
System.Console.WriteLine(wedge.superAttack(5));
System.Console.WriteLine();
System.Console.WriteLine(topapa.attack());
System.Console.WriteLine();
System.Console.WriteLine(jenica.superAttack(3));


