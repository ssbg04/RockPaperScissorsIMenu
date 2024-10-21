class P2pPlay
{
  private Random _random = new Random();
    
    public void Play()
    {
        bool restart = true;

        while (restart)
        {
            int playerOnePick = GetPlayerPick("Player One");
            if (playerOnePick == 4) return;

            int playerTwoPick = GetPlayerPick("Player Two");
            if (playerTwoPick == 4) return;

            DisplayResult(playerOnePick, playerTwoPick);
            Thread.Sleep(2000);
        }
    }

    private int GetPlayerPick(string playerName)
    {
        Console.Clear();
        Console.WriteLine($"{playerName}, type and enter (1/2/3/4): 1 = Rock, 2 = Paper, 3 = Scissors, 4 = exit");
        Console.Write($"{playerName}: ");
        return int.Parse(Console.ReadLine());
    }

    private void DisplayResult(int playerOnePick, int playerTwoPick)
    {
        string[] choices = { "Rock", "Paper", "Scissors" };
        string result;

        if (playerOnePick == playerTwoPick)
        {
            result = "NO WIN, TIE!";
        }
        else if ((playerOnePick == 1 && playerTwoPick == 3) ||
                 (playerOnePick == 2 && playerTwoPick == 1) ||
                 (playerOnePick == 3 && playerTwoPick == 2))
        {
            result = "PLAYER ONE WIN!";
        }
        else
        {
            result = "PLAYER TWO WIN!";
        }

        Console.Clear();
        Console.WriteLine($"Player One Picked: {choices[playerOnePick - 1]}");
        Console.WriteLine($"Player Two Picked: {choices[playerTwoPick - 1]}");
        Console.WriteLine(result);
    }
}