using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingStateAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            BowlingGame game = new BowlingGame();
            //see what happens when rolling a 10
            //testing to see if I roll more than 13 strikes, it wont add the last strike
            game.Roll(10);
            game.Roll(10);
            game.Roll(10);
            game.Roll(10);
            game.Roll(10);
            game.Roll(10);
            game.Roll(10);
            game.Roll(10);
            game.Roll(10);
            game.Roll(10);
            game.Roll(10);
            game.Roll(10);
            game.Roll(10);
            game.Roll(10);

            Console.WriteLine($"Score: {game.Score()}");
            Console.ReadLine();
        }
    }
}
