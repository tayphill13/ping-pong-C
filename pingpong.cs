using System;
namespace PingPong  
{
  public class Program  
  {
    static void Main(string[] args) 
    {
      Console.WriteLine("Enter a number to count to: ");
      string stringNumber = Console.ReadLine();
      int userNumber = int.Parse(stringNumber);

      for (int i = 1; i <= userNumber; i++)  
      {
        if (i % 3 == 0 && i % 5 == 0) 
        {
          Console.WriteLine("Ping Pong");
        } 
        else if (i % 3 == 0) 
        {
          Console.WriteLine("Ping");
        } 
        else if (i % 5 == 0)  
        {
          Console.WriteLine("Pong");
        } 
        else 
        {
          Console.WriteLine(i);
        }
      }
    }
  }
}