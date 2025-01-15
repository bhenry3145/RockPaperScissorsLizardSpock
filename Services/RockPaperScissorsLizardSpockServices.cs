using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock.Services
{
    public class RockPaperScissorsLizardSpockServices
    {
        public int randomNum;
        public string? response;
        public Random rng = new Random();
        public List<string> ComputerChoices = new List<string> {
            "Rock",
            "Paper",
            "Scissors",
            "Lizard",
            "Spock"
        };

        public string PlayGame()
        {
            randomNum = rng.Next(ComputerChoices.Count);
            return ComputerChoices[randomNum];
        }
    }
}