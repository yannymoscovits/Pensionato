using System;

namespace Pensionato
{
    class Program
    {
        static void Main(string[] args)
        {

            Quartos[] vect = new Quartos[10];
         
            Console.WriteLine("How many rooms will be rented? :");
            int n = int.Parse(Console.ReadLine());

            

         for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(" RENT #"+i+" :"     );
                
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Email :");
                string email = Console.ReadLine();
                Console.WriteLine("Room :");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new Quartos(name, email);
            }

            Console.WriteLine("Busy rooms : ");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null) {
                    Console.WriteLine( i + ":" + vect[i]);
                }
               
            }
         
        }
    }
}