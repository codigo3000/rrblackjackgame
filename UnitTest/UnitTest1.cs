using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJack;

namespace UnitTest
{
    [TestClass]
    public class TestBlackJack
    {
        [TestMethod]

        public void TestGetCard()
        {
            // Arrange.
            const int cardMax = 10;

            cards card = new cards();

            // Test.
            bool valueIncorrect = false;

            var result = card.getCard();

            if (result <= cardMax)
            {
                valueIncorrect = false;
            }
            else
            {
                valueIncorrect = true;
            }

            // Assert or Affirmation.
            Assert.IsFalse(valueIncorrect);

        }

        [TestMethod]
        public void TestNumberUserCard()
        {
            // Arrange.
            const int numbersCard = 17;

            cards card = new cards();

            // Test.
            bool valueIncorrect = false;
            int userCard = card.getCard();
            int totalUserScoreCard = card.totalUserScoreSave(userCard);
            int totalListUserCard = card.totalListUserCard();

            // Assert or Affirmation.
            if (totalListUserCard <= numbersCard)
            {
                valueIncorrect = false;
            }
            else
            {
                valueIncorrect = true;
            }

            // Assert or Affirmation.
            Assert.IsFalse(valueIncorrect);
        }

        [TestMethod]
        public void TestNumberComputerCard()
        {
            // Arrange.
            const int numbersCard = 17;

            cards card = new cards();

            // Test.
            bool valueIncorrect = false;
            int computerCard = card.getCard();
            int totalComputerScoreCard = card.totalComputerScoreSave(computerCard);
            int totalListComputerCard = card.totalListComputerCard();


            if (totalListComputerCard <= numbersCard)
            {
                valueIncorrect = false;
            }
            else
            {
                valueIncorrect = true;
            }

            // Assert or Affirmation.
            Assert.IsFalse(valueIncorrect);
        }

        [TestMethod]
        public void TestScoreUserCard()
        {
            // Arrange
            const int totalScoreResul = 21;

            cards card = new cards();

            // Test
            List<int> userCardList = new List<int>();
            userCardList.Add(7);
            userCardList.Add(9);
            userCardList.Add(5);

            int totalUserScoreCard = 0;

            foreach (int element in userCardList)
            {
                totalUserScoreCard = card.totalUserScoreSave(element);
            }

            // Assert or Affirmation.
            Assert.AreEqual(totalScoreResul, totalUserScoreCard);
        }

        [TestMethod]
        public void TestScoreComputerCard()
        {
            // Arrange
            const int totalScoreResul = 21;

            cards card = new cards();

            // Test
            List<int> computerCardList = new List<int>();
            computerCardList.Add(7);
            computerCardList.Add(9);
            computerCardList.Add(5);

            int totalComputerScoreCard = 0;

            foreach (int element in computerCardList)
            {
                totalComputerScoreCard = card.totalComputerScoreSave(element);
            }

            // Assert or Affirmation.
            Assert.AreEqual(totalScoreResul, totalComputerScoreCard);
        }

        [TestMethod]
        public void TestTotalNumberUserCard()
        {
            // Arrange
            int totalScoreResul = 16;

            cards card = new cards();

            // Test
            List<int> userCardList = new List<int>();
            userCardList.Add(1);
            userCardList.Add(2);
            userCardList.Add(3);
            userCardList.Add(4);
            userCardList.Add(5);
            userCardList.Add(6);
            userCardList.Add(7);
            userCardList.Add(8);
            userCardList.Add(9);
            userCardList.Add(1);
            userCardList.Add(2);
            userCardList.Add(3);
            userCardList.Add(4);
            userCardList.Add(5);
            userCardList.Add(6);
            userCardList.Add(7);
            //userCardList.Add(7); --> Error

            int totalUserScoreCard = 0;                        

            foreach (int element in userCardList)
            {
                totalUserScoreCard = card.totalUserScoreSave(element);
            }

            int totalNumberUserCard = card.totalListUserCard();

            if (totalNumberUserCard <= totalScoreResul)
            {
                totalScoreResul = totalNumberUserCard;
            }

            // Assert or Affirmation.
            Assert.AreEqual(totalScoreResul, totalNumberUserCard, "Card numbers less than 17.");
        }

        [TestMethod]
        public void TestTotalNumberComputerCard()
        {
            // Arrange
            int totalScoreResul = 16;

            cards card = new cards();

            // Test
            List<int> computerCardList = new List<int>();
            computerCardList.Add(1);
            computerCardList.Add(2);
            computerCardList.Add(3);
            computerCardList.Add(4);
            computerCardList.Add(5);
            computerCardList.Add(6);
            computerCardList.Add(7);
            computerCardList.Add(8);
            computerCardList.Add(9);
            computerCardList.Add(1);
            computerCardList.Add(2);
            computerCardList.Add(3);
            computerCardList.Add(4);
            computerCardList.Add(5);
            computerCardList.Add(6);
            computerCardList.Add(7);
            //computerCardList.Add(7); //--> Error

            int totalComputerScoreCard = 0;

            foreach (int element in computerCardList)
            {
                totalComputerScoreCard = card.totalComputerScoreSave(element);
            }

            int totalNumberComputerCard = card.totalListComputerCard();

            if (totalNumberComputerCard <= totalScoreResul)
            {
                totalScoreResul = totalNumberComputerCard;
            }

            // Assert or Affirmation.
            Assert.AreEqual(totalScoreResul, totalNumberComputerCard, "Card numbers less than 17.");
        }

        [TestMethod]
        public void TestThrowException_NumberUserCard()
        {
            cards card = new cards();
                       
            try
            {
                int totalUserScoreCard = card.totalUserScoreSave(0);
                int totalListUserCard = card.totalListUserCard();

                Assert.Fail("no exception thrown");
            }
            catch(Exception ex)
            {
                Assert.IsTrue(true,ex.Message);
            }

        }

        [TestMethod]
        public void TestThrowException_NumberComputerCard()
        {
            cards card = new cards();

            try
            {
                int totalComputerScoreCard = card.totalComputerScoreSave(0);
                int totalListComputerCard = card.totalListComputerCard();

                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(true, ex.Message);
            }

        }

        [TestMethod]
        public void TestException_GetCard()
        {
            // Arrange.
            var value = 0;

            try
            {
                var seed = Environment.TickCount;
                var random = new Random(seed);

                value = random.Next(0, 1);

                if (value == 0)
                {
                    throw new Exception();
                }

                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(true, ex.Message);
            }
            
        }
    }
}
