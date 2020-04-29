using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class cards
    {
        List<int> userCardList = new List<int>();
        List<int> computerCardList = new List<int>();

        // Method to get card.
        public int getCard()
        {
            var value = 0;

            try
            {
                var seed = Environment.TickCount;
                var random = new Random(seed);

                value = random.Next(1, 10);
            }
            catch(Exception ex)
            {
                value = 0;
                throw new Exception(ex.Message);
            }

            return value;
        }


        // Function for get total Score
        // Return int
        public int totalUserScoreSave(int totalCars)
        {
            int total = 0;
           
                if (totalCars == 0)
                {
                    throw new Exception();
                }

                userCardList.Add(totalCars);

                foreach (int element in userCardList)
                {
                    total += element;
                }
           
            return total;
        }

        // Function for get total of the cards in the list.
        // Return int
        public int totalListUserCard()
        {
            return userCardList.Count;
        }

        // Function for get total Score
        // Return int
        public int totalComputerScoreSave(int totalCars)
        {
            int total = 0;

            if (totalCars == 0)
            {
                throw new Exception();
            }

            computerCardList.Add(totalCars);

            foreach (int element in computerCardList)
            {
                total += element;
            }

            return total;
        }

        // Function for get total of the cards in the list.
        // Return int
        public int totalListComputerCard()
        {
            return computerCardList.Count;
        }


    }
}
