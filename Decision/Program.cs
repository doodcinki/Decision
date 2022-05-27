namespace Decision
{
    internal class Program
    {
        static void Main(string[] args)
        /*  {
              Console.WriteLine("Szymona Rozdawanie");
              Console.WriteLine("Wybierz drzwi: 1, 2, lub 3: ");
              string userValue = Console.ReadLine();

              string message = "";

              if (userValue == "1")

                   message = "Wygrales talon";
              else if (userValue == "2")
                   message = "Wygrales Balon";
              else if (userValue == "3")
                   message = "Wygrales taczke gruzu";

              else
              {
                  message = "Nawet nie umiesz wcisnac odpowiedniego. ";
                  message = message + "Milego dnia! ";
                   }
              Console.WriteLine(message);
              Console.ReadLine();
        */
        {
            Console.WriteLine("Szymona Rozdawanie");
            Console.WriteLine("Wybierz drzwi: 1, 2, lub 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "Wygrales Balon" : "wygrales taczke gruzu";
            //Console.Write("Czy ");
            //Console.Write(message);
            //Console.Write(".");
            //Console.ReadLine();

            Console.WriteLine("Wybrales: {0}., Jednakze {1}. ", userValue, message);
            Console.ReadLine();
        }
    }
}
