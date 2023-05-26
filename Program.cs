using System;

namespace Interfaces_Houston_Morgan
{
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game("E", "FPS", "ZombCube");
            Console.WriteLine(myGame.Describe());
            myGame.PlayGame();

            Movie myMovie = new Movie("PG", "Adventure/Comedy", "Sonic the Hedgehog 2");
            Console.WriteLine(myMovie.Describe());
            myMovie.PlayMovie();
        }
    }
}
