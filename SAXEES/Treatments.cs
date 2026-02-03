using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAXEES
{
    internal class Treatments
    {
        private UI = _ui;

        public Treatments()
        {
            _ui = new UI();
        }
        public bool VisaBenhandlingsmeny()
        {
            int menyVal;
            int min = 1;
            int max = 4;

            Console.WriteLine("\tBEHANDLINGSMENY\n\n");

            Console.WriteLine("Ange siffran för ditt val och tryck enter:");
            Console.WriteLine();
            Console.WriteLine("1. Visa alla behandlingar");
            Console.WriteLine("2. Visa priser");
            Console.WriteLine("3. Visa tillgänglig personal på de olika behandlingarna");
            Console.WriteLine("4. Tillbaka till huvudmeny");

            while (!int.TryParse(Console.ReadLine(), out menyVal) || menyVal < min || menyVal > max)
            {
                Console.WriteLine("Vänligen ange ett tal som alternativ, mellan 1-4!");
            }


            return Behandlingsmeny(menyVal);
        }

        public bool Behandlingsmeny(int menyVal)
        {
            switch (menyVal)
            {
                case 1:
                    Console.Clear();
                    VisaBehandlingar();
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    VisaPriser();
                    Console.ReadKey();
                    break;
                case 3:
                    VisaTillgängligPersonal();
                    Console.ReadKey();
                    break;
                case 4:
                    _ui.VisaHuvudmeny();
                    return false;

            }
            return true;
        }
    }
}
