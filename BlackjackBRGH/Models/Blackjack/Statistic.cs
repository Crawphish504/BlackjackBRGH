using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackjackBRGH.Models.Blackjack
{
    public class Statistic
    {

        //Statistics
        public static int DealerWins { get; private set; } = 0;
        public static int PlayerWins { get; private set; } = 0;
        public static int Draws { get; private set; } = 0;


                
        // Reset Statistics    
        public static void ResetStat()
        {
            DealerWins = 0;
            PlayerWins = 0;
            Draws = 0;
        }

        public static void AddPlayerWin()
        {
            PlayerWins++;
        }
        public static void AddDealerWin()
        {
            DealerWins++;
        }
        public static void AddDraw()
        {
            Draws++;
        }

    }
}
