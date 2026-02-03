using SAXEES.Models;

namespace SAXEES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            using (var ctx = new SaxessContext())
            {
                foreach (var customer in ctx.Customers)
                {
                    Console.WriteLine(customer.Name);
                }
            }
        }
    }
}
