using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada eesnime;
            //programm kusib kasutajal sisestada numbrit 1-3;
            //kui kasutaja valib '1', siis kuvatakse kasutaja eesnime tagurpidi;
            //kui kasutaja valib '2', siis kuvatakse kasutaja eesnime esimest tahte;
            //kui kasutaja valib '3', siis kuvatakse kasutaja eesnime pikkust;

            Console.WriteLine("sisesta oma eesnimi:");
            string userName = Console.ReadLine();

            Console.WriteLine("Vali arv 1-3 :");
            char userNumber = Convert.ToChar(Console.ReadLine());

            switch (userNumber)
            {
                case '1':
                    Reverse(userName);
                    break;
                case '2':
                    FirstLetter(userName);
                    break;
                case '3':
                    Lenght(userName);
                    break;

                default:
                    Console.WriteLine("Kena paeva!");
                    break;
            }
        }

        public static void Reverse(string userName)
        {
            for (int i = userName.Length - 1; i >= 0; i--)
            {
                Console.Write(userName[i]);
            }
        }

        public static void FirstLetter(string useName)
        {
            Console.WriteLine($"Sinu eesnime esimene taht on {useName[0]}");
        }
        public static void Lenght(string useName)
        {
            Console.WriteLine($"Sinu nimi on {useName.Length} sumbolit pikk.");
        }
    }
}