using System;
namespace PingPong  {
  public class Program  {
    static void Main(string[] args) {
      for (int i = 1; i <= 100; i++)  {
        if (i % 3 == 0 && i % 5 == 0) {
          Console.WriteLine("Ping Pong");
        } else if (i % 3 == 0) {
          Console.WriteLine("Ping");
        } else if (i % 5 == 0)  {
          Console.WriteLine("Pong");
        } else {
          Console.WriteLine(i);
        }
      }
    }
  }
}