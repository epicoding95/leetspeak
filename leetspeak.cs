using System;
using System.Collections.Generic;



namespace leetspeak
{
  public class anything
  {



      public static void Main()
   {
       Console.WriteLine("welcome to L33tSpeak");
       Console.WriteLine("Enter whatever you want to be made l33t");
       string newName = Console.ReadLine();
       Console.WriteLine("your leet sentence is:");
       string replacedName = newName.Replace("e", "3").Replace("o", "0").Replace("i", "1").Replace("t", "7").Replace("s", "z");
        Console.WriteLine(replacedName);
      Console.WriteLine("want to make anymore l3333t sentences?");
      string answer = Console.ReadLine();

      if(answer == "yes")
      {
        Main();
      }
      else
      {
        Console.WriteLine("peace");
      }
        
    

    string IsLeetLetter(string letter)
   {
       string taker = letter;
       if(taker == "e" || taker == "E")
       {
           return "3";
       }

       else if  (taker == "o"|| taker == "O")
       {
           return "0";
       }

       else if (taker == "i" || taker == "I")
       {
           return "1";
       }

       else if (taker == "t" || taker =="T")
       {
           return "7";
       }

       else if  (taker == "s" || taker =="S")
       {
           return "Z";
       }
       else
       {
           return taker;
       }
        
   }

   
  
   

  }
  }
}

