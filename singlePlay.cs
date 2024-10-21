using System;

public class singlePlay
{
    private int playerWinStreak;

    public void Play()
    {
        bool userRestart = true;

        while (userRestart)
        {
            Console.Clear();
            DisplayInstructions();
            int playerChoice = GetPlayerChoice();

            if (playerChoice == 4)
            {
                Console.WriteLine("Game Exit...");
                break;
            }

            int cpuChoice = new Random().Next(1, 4);
            DisplayRoundResult(playerChoice, cpuChoice);
            UpdateWinStreak(playerChoice, cpuChoice);
            Thread.Sleep(1500);
        }
    }

    private void DisplayInstructions()
    {
        Console.WriteLine("Type and Enter (1/2/3/4): 1 = Rock, 2 = Paper, 3 = Scissors, 4 = Exit");
        Console.WriteLine($"Win Streak: {playerWinStreak} \t\tInput: ");
    }

    private int GetPlayerChoice()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 4)
                return choice;

            Console.WriteLine("Invalid input. Please choose 1, 2, 3, or 4.");
        }
    }

    private void DisplayRoundResult(int playerChoice, int cpuChoice)
    {
        string[] choices = { "Rock", "Paper", "Scissors" };
        Console.WriteLine($"You picked {choices[playerChoice - 1]}, CPU picked {choices[cpuChoice - 1]}");

        if (playerChoice == cpuChoice)
        {
            Console.WriteLine("TIE!");
        }
        else if ((playerChoice == 1 && cpuChoice == 3) || 
                 (playerChoice == 2 && cpuChoice == 1) || 
                 (playerChoice == 3 && cpuChoice == 2))
        {
            Console.WriteLine("YOU WIN!");
            playerWinStreak++;
        }
        else
        {
            Console.WriteLine("YOU LOSE!");
            playerWinStreak = 0;
        }
    }

    private void UpdateWinStreak(int playerChoice, int cpuChoice)
    {
        // Win streak update logic is already handled in DisplayRoundResult
    }
}
