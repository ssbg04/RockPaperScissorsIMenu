using System;
using System.Linq;

public class InteractiveMenu
{
  int selected = 1;
  public void Menu()
  {
    Console.ForegroundColor = ConsoleColor.Yellow;
    System.Console.WriteLine("Use Up and Down Arrow keys to navigate, press Enter/Return to select");
    Console.ResetColor();

    bool IsSelected = false;
    ConsoleKeyInfo key;
    string hoverColor = ">  \u001b[32m";
    (int left, int top) = Console.GetCursorPosition();


    while(!IsSelected)
    {
      Console.SetCursorPosition(left, top);
      System.Console.WriteLine($"{(selected == 1? hoverColor: "   ")}Singleplayer Mode (Against CPU)\u001b[0m");
      System.Console.WriteLine($"{(selected == 2? hoverColor: "   ")}Two-Player Mode (P2P)\u001b[0m");

      key = Console.ReadKey(true);

      switch(key.Key)
      {
        case ConsoleKey.DownArrow:
          selected = (selected == 2? 1: selected + 1);
          break;
        case ConsoleKey.UpArrow:
          selected = (selected == 1? 2: selected - 1);
          break;
        case ConsoleKey.Enter:
          IsSelected = true;
          break;
      }
    }

    
  }

  public void playGame()
  {
    singlePlay play = new singlePlay();
    P2pPlay play1 = new P2pPlay();
    if(selected != 1)
    {
      play1.Play();
    }else{
      play.Play();
    }
  }
  
}