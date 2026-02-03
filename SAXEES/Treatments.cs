using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAXEES
{
    internal class Treatments
    {
        //private UI _ui;

        //public Treatments()
        //{
        //    _ui = new UI();
        //}
        public bool VisaBenhandlingsmeny()
        {
            Console.WriteLine("\tBEHANDLINGSMENY\n\n");

            Console.WriteLine("Ange siffran för ditt val och tryck enter:");
            Console.WriteLine();
            Console.WriteLine("1. Visa alla behandlingar");
            Console.WriteLine("2. Visa priser");
            Console.WriteLine("3. Visa tillgänglig personal på de olika behandlingarna");
            Console.WriteLine("4. Tillbaka till huvudmeny");
            int menyval = UI.DittValNR("Ditt val");
                      
            return Behandlingsmeny(menyval);
        }

        public bool Behandlingsmeny(int menyval)
        {
            switch (menyval)
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
                    Console.Clear();
                    VisaTillgängligPersonal();
                    Console.ReadKey();
                    break;
                case 4:
                    UI.StartaHuvudmenyn();
                    return false;

            }
            return true;
        }

        public void VisaBehandlingar()
        {
            Console.WriteLine("BEHANDLINGAR");
            Console.WriteLine();
            //TreatmentData.VisaBehandlingar();
        }

        public void VisaPriser()
        {
            Console.WriteLine("PRISER");
            Console.WriteLine();
            //TreatmentData.VisaPriser();
        }

        public void VisaTillgängligPersonal()
        {
            Console.WriteLine("PERSONAL FÖR VARJE BEHANDLING");
            Console.WriteLine();
            //TreatmentData.VisaTillgängligPersonal();
        }
    }
}
