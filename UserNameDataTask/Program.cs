using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnimie;
            //programm küsib kasutajal sisestada numbrit 1-3;
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnime tagurpidi
            //kui kasutaja valib '2', siis kuvatakse kasutaja eesnime esimest tähte
            //kui kasutaja valib '3', siis kuvatakse kasutaja eesnime pikkust

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta number '1', '2' või '3':");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch (userOperator)
            {
                case '1':
                    NameBackwards(userName);
                    break;
                case '2':
                    FirstLetter(userName);
                    break;
                case '3':
                    NameLength(userName);
                    break;
                default:
                    Console.WriteLine("Sisestasid vale väärtuse.");
                    Console.WriteLine("Kena päeva!");
                    break;
            }
        }

        public static void NameBackwards(string userInput)
        {
            Console.WriteLine("Sinu eesnimi tagurpidi on...");
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }

        public static void FirstLetter(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}.");
        }

        public static void NameLength(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
        }

    }
}
