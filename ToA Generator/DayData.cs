using System;
using System.Collections;

namespace DayData
{


    class DayData
    {
        private string noEnc = "No Encounter";

        private string morningRain;
        private string eveningRain;
        private string morningEncounter = "";
        private string midEncounter = "";
        private string lateEncounter = "";

        public DayData()
        {
            morningRain = GenerateRain();
            eveningRain = GenerateRain();
        }

        public string GenerateRain()
        {
            DiceRoller die = new DiceRoller();
            int select = die.Roll(1,5);
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
                    Boolean isStorm;
                    if (die.Roll100() > 75) isStorm = true;
                    else isStorm = false;
                    if (isStorm) rain = "Tropical Storm";
                    else rain = "Heavy Rain";
                    break;
                default:
                    rain = "Error in DayData.Day.GenerateRain()";
                    break;
            }
            return rain;
        }
    }
}
