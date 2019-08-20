﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace sweepstakes
{
    class Sweepstakes
    {
        Dictionary<int, Contestant> contestantDictionary;
        string name;

        public Sweepstakes(string name)
        {

            this.name = name;

        }

        private void RegisterContestant(Contestant contestant)
        {
            contestant.registrationNumber = contestantDictionary.Count + 1;
            int TicketNumber = contestant.registrationNumber;
            contestant.firstName = UserInterface.GetUserStringInput("Please enter contestant's first name");
            contestant.lastName = UserInterface.GetUserStringInput("Please enter contestant's last name");
            contestant.emailAddress = UserInterface.GetUserStringInput("Please enter contestant's email address");
            contestantDictionary.Add(TicketNumber, contestant);

        }

        private string PickWinner()
        {
            int WinningSpot = UserInterface.GetRandom(1, contestantDictionary.Count + 1);
            string Winner = $"The Winner is {contestantDictionary[WinningSpot].firstName } {contestantDictionary[WinningSpot].lastName}";
            return Winner;
        }

        private void PrintContestantInfo(Contestant contestant)
        {
          Console.WriteLine($"{contestant.firstName} \n {contestant.lastName} \n {contestant.emailAddress} \n {contestant.registrationNumber}");  
        }

       
    }
}
