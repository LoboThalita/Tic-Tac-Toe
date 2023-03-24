
using Hash;

Game play = new Game();

Board Board = new Board();

Board.Print();
play.Match(Board);

if (Board.Checks() == 1) Console.WriteLine("Jogador um Venceu!!");
if (Board.Checks() == 2) Console.WriteLine("Jogador dois Venceu!!");
if (Board.Checks() == 3) Console.WriteLine("Empate");
