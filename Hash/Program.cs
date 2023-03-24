
using Hash;

Game play = new Game();

Console.WriteLine("Bem-vindo ao jogo da velha\n\n");

Board Board = new Board();

Board.Print(0);
play.Match(Board);