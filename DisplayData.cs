using System;
using System.Collections;

namespace DayData
{


    class ToADay
    {
        private readonly string noEnc = "No Encounter";

        private string morningRain;
        private string eveningRain;
        private string morningEncounter = noEnc;
        private string midEncounter = noEnc;
        private string lateEncounter = noEnc;

        public ToADay()
        {

        }

        public GenerateRain()
        {
            DiceRoller dice = new DiceRoller();
            int select = dice.Roll(1, 5);
            string rain = "";

            switch (select)
            {
                case 1:
                    rain = "No Rain";
                    break;
                case 2:
                    rain = "Drizzle";
                    break;
                case 3:
                    rain = "Light Rain";
                    break;
                case 4:
                    rain = "Normal Rain";
                    break;
                case 5:
                    Boolean isStorm = (dice.Roll100() > 75);
                    if (isStorm) rain = "Tropical Storm";
                    else rain = "Heavy Rain";
                    break;
                default:
                    rain = "Error in DayData.ToADay.GenerateRain()";

                    
            }
        }
    }
}
