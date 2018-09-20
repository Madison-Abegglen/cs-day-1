using System;
using System.Collections.Generic;
using cs_day_1.Models;

namespace cs_day_1
{
  class Program
  {
    static void Main(string[] args)
    {
      bool playing = true;
      // Console.Clear();

      // what you'd want an array to be, google it
      // List<string> choices = new List<string>(){"rock", "paper", "scissors"}
      // google what the syntax is on a C# dictionary 
      // Dictionary<string, string> dictionaryChoices = new Dictionary<string, string>();
      // dictionaryChoices.Add("rock", "paper"); because paper beats rock, duh
      // google it, instantiate random and theres a method that you can use  
      // Random<>
      // you're gonna create a while loop that you will either win or lose for each iteration

      Random rnd = new Random();
      string[] choices = { "Rock", "Paper", "Scissors" };
      // Generate random indexes 

      while (playing)
      {
        int choicesIndex = rnd.Next(choices.Length);
        Console.WriteLine("Welcome to the game. Do you wish to play? (Y/N)");
        string response = Console.ReadLine();
        if (response.ToUpper() != "Y")
        {
          playing = false;
          continue;
        }
        Console.WriteLine("(' - ' ) So be it. Is your choice: 1(rock), 2(paper), or 3(scissors)?");
        string playerChoice = Console.ReadLine();
        Console.WriteLine($"You chose: {playerChoice}");
        string compChoice = choicesIndex.ToString();
        Console.WriteLine($"I chose: {compChoice}");
        if (playerChoice == compChoice)
        {
          Console.WriteLine("So it's come to a tie... very well.");
        }
        if (playerChoice == "1" && compChoice == "3")
        {
          Console.WriteLine("I chose scissors.. looks like you won. Next time I won't go so easy.");
        }
        if (playerChoice == "1" && compChoice == "2")
        {
          Console.WriteLine("Ha-Ha! I chose paper. I won. You lost. ( ' U ')");
        }
        if (playerChoice == "2" && compChoice == "1")
        {
          Console.WriteLine("Since I chose rock, it looks like you won.");
        }
        if (playerChoice == "2" && compChoice == "3")
        {
          Console.WriteLine("Would'ya look at that. I chose scissors.. snip snip! You lose.");
        }
        if (playerChoice == "3" && compChoice == "1")
        {
          Console.WriteLine("Oof, I've got a rock. You've got crushed scissors. You lose.");
        }
        if (playerChoice == "3" && compChoice == "2")
        {
          Console.WriteLine("Just because I chose paper doesn't mean you had to cut it up with them scissors. You won this round....");
        }
      };


      // while (playing)
      // {
      //   Console.WriteLine("Hello what's your name?");
      //   string name = Console.ReadLine();
      //   Console.WriteLine("Oh hello " + name);

      //   if (name != null)
      //   {
      //     Console.WriteLine("What's up doc?");
      //   }
      //   Console.WriteLine("How old are you?");
      //   string myAgeString = Console.ReadLine();
      //   int age;

      //   if (!Int32.TryParse(myAgeString, out age))
      //   {
      //     Console.WriteLine("Bad Input!");
      //     return;
      //   }
      //   Console.WriteLine($"Cool! Did you know in 10 years you will be {age + 10}?");
      //   // a TYPE - aka a class
      //   User user = new User(name, age);
      //   Console.WriteLine($"Anywho I made a user object with the name {user.Name}, and the age {user.Age}.");
      //   System.Console.WriteLine("Wait.... I forgot? Will you tell me again? (Y/N)");
      //   string response = Console.ReadLine();
      //   if(response.ToUpper() != "Y")
      //   {
      //     playing = false;
      //   }
      // }
    }
  }
}
