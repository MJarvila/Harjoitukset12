using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj12Teht1
{
    class Dice
    {
        Random dice = new Random();
        private int rollCount, onecount, twocount, threecount, fourcount, fivecount, sixcount;
        public void Roll(int rolls)
        {
            for (int i = 0; i < rolls; i++)
            {
                rollCount++;
                int roll = dice.Next(1, 7);

                if (roll == 1)
                {
                    onecount++;
                }
                else if (roll == 2)
                {
                    twocount++;
                }
                else if (roll == 3)
                {
                    threecount++;
                }
                else if (roll == 4)
                {
                    fourcount++;
                }
                else if (roll == 5)
                {
                    fivecount++;
                }
                else if (roll == 6)
                {
                    sixcount++;
                }
            }
            float total = onecount + twocount + threecount + fourcount + fivecount + sixcount;
            float average = (onecount + 2 * twocount + 3 * threecount + 4 * fourcount + 5 * fivecount + 6 * sixcount) / total;
            Console.WriteLine("Heitit noppaa {0} kertaa, ja heittojesi keskiarvo on {1}", rolls, average);
            Console.WriteLine("Sait {0} ykköstä, {1} kakkosta, {2} kolmosta, {3} nelosta, {4} viitosta ja {5} kuutosta", onecount, twocount, threecount, fourcount, fivecount, sixcount);
        }
    }
}
