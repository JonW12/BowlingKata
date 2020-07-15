using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingKata;

namespace BowlingKataTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGutterGame()
        {
            BowlingKata.Game game = new BowlingKata.Game();
            for (int i = 0; i < 20; i++)
            {
                game.roll(0);
            }
        }
    }
}
