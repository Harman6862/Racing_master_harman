using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing_master_harman
{
    public class checkEntries
    {
        public int player1 = 120, player2 = 120, player3 = 120;

        Random instance_rnd = new Random();

        //random no generate and pass to the main class for working 
        public int genStep() {
            return instance_rnd.Next(1, 50);
        }

        public int resetAccount1(int betAmount, int dog, int winner, int flag) {


            if (dog == winner)
            {
                player1 += betAmount;
            }
            else {
                player1 -= betAmount;
            }
            return player1;
        }
        public int resetAccount2(int betAmount, int dog, int winner, int flag)
        {

                if (dog == winner)
                {
                    player2 += betAmount;
                }
                else
                {
                    player2 -= betAmount;
                }
            return player2;
        }

        public int resetAccount3(int betAmount, int dog, int winner, int flag)
        {
                if (dog == winner)
                {
                    player3 += betAmount;
                }
                else
                {
                    player3 -= betAmount;
                }
            return player3;
        }

        

    }
}
