using System;

namespace _1_first_project {
    class Program {
        static void Main(string[] args) {
            string name = null;
            sbyte age = 0;

            Console.Write("Podaj imie: ");
            name = Console.ReadLine();

            Console.Write("Podaj wiek: ");
            age = 20;
            Console.WriteLine("Imię: {0} | Wiek: {1}", name, age);

            // Method - 1
            Console.WriteLine("#\n##\n###");

            // Method - 2
            Console.WriteLine("#");
            Console.WriteLine("##");
            Console.WriteLine("###");

            // Method - 3
            for (int i = 0; i < 6; i++) {
                Console.Write("#");
                if (i == 0 || i == 2) {
                    Console.Write("\n");
                }
            }

            // W8 for info ^^
            Console.ReadLine();
        }
    }
}
