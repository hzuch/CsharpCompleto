using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Pensioner[] rooms = new Pensioner[10];

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Rent #" + (i + 1) + ":");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());

                rooms[roomNumber] = new Pensioner { Name = name, Email = email };
            }

            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine(i + ": " + rooms[i].ToString()); 
                }
            }
        }
    }
}
