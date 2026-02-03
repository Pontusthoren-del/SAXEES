using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAXEES
{
    internal class UI
    {
        public static void StartaHuvudmenyn()
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Välkomna till Saxees");
                Console.WriteLine("1) Behandlingar");
                Console.WriteLine("2) Bokningar");
                Console.WriteLine("3) Kundlista");
                Console.WriteLine("4) Avsluta");

                int choice = DittValNR("Ditt val: ");

                switch (choice)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        running = false;
                        break;
                }
            }
        }
        public static int DittValNR(string prompt)
        {
            int choice;
            Console.Write(prompt);
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.Write("Ogiltligt val, försök igen");
            }
            return choice;
        }
    }
}
