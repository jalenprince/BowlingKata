using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingStateAuto
{
    public class BowlingGame
    {
        //there are a max of 21 rolls in bowling
        private readonly int[] rolls = new int[21];
        //counting the current rolls
        private int currentRoll;
        //counts the score
        private int score;

        //each roll
        public void Roll(int pinsKnocked)
        {
            rolls[currentRoll++] = pinsKnocked;
        }

        public int Score()
        {
            var roll = 0;
            //counts the frames up to 10
            for (var frame = 0; frame < 10; frame++)
            {
                //checks if roll is a strike
                if (Strike(roll))
                {
                    score += StrikeBonus(roll);
                    roll++;
                }
                //checks if roll is a spare
                else if (Spare(roll))
                {
                    score += SpareBonus(roll);
                    roll += 2;
                }
                //normal rolls
                else
                {
                    score += NormalScorePoints(roll);
                    roll += 2;
                }             
            }
            return score;
        }

        private int NormalScorePoints(int roll)
        {
            return rolls[roll] + rolls[roll + 1];
        }

        private int SpareBonus(int roll)
        {
            return 10 + rolls[roll + 2];
        }
        //calculation when strikes happens
        private int StrikeBonus(int roll)
        {
            //strike is 10 + the next two frames for the frame the played roll a strike
            return 10 + rolls[roll + 1] + rolls[roll + 2];
        }
        //if player get strike
        private bool Strike(int roll)
        {
            return rolls[roll] == 10;
        }
        //if player get spare
        private bool Spare(int roll)
        {
            return rolls[roll] + rolls[roll + 1] == 10;
        }
    }
}
