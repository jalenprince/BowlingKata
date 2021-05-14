using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BowlingStateAuto;

namespace GameTests
{
    [TestClass]
    public class UnitTest1
    {
        private BowlingGame game;

        [TestInitialize]
        public void Ready()
        {
            game = new BowlingGame();
        }
        [TestMethod]
        //testing to see if roll all 0s
        public void RollGutter()
        {
            multipleRolls(0, 20);
            Assert.AreEqual(0, game.Score());
        }


        [TestMethod]
        //testing to see if someone rolls all ones
        public void RollAllOnes()
        {
            multipleRolls(1, 20);
            Assert.AreEqual(20, game.Score());
        }

        [TestMethod]
        //testing to see if roll a spare
        public void RollSpare()
        {
            game.Roll(5);
            game.Roll(5);
            game.Roll(3);
            multipleRolls(0, 17);
            Assert.AreEqual(16, game.Score());
        }

        [TestMethod]
        //testing to see if player rolls a strike
        public void RollStrike()
        {
            game.Roll(10);
            game.Roll(0);
            game.Roll(2);
            multipleRolls(0, 16);
            Assert.AreEqual(14, game.Score());
        }

        //method for rolling and pins being knocked
        private void multipleRolls(int pinsKnocked, int roll)
        {
            for (var i = 0; i < roll; i++)
                game.Roll(pinsKnocked);
        }
    }
}
