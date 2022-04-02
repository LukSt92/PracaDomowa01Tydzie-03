using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowa01Tydzień03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj, w prostej aplikacji konsolowej zbierającej proste dane.\nProszę podaj swoję imię:");
            var name = Console.ReadLine();

            Console.WriteLine("Następnie podaj nazwę miejscowości w której się urodziłeś:");
            var city = Console.ReadLine();

            try
            {
                Console.WriteLine("Na koniec proszę podaj swoją datę urodzenia w następującym formacie: dd.MM.yyyy:");
                var bday = DateTime.Parse(Console.ReadLine());

                var today = DateTime.Now;

                if (bday.Year < today.Year && bday.Month > today.Month || bday.Year < today.Year && bday.Month == today.Month && bday.Day > today.Day)
                {
                    var age = today.Year - bday.Year - 1;
                    Console.WriteLine($"Cześć {name}. Urodziłeś się w {city} i masz {age} lat.");
                }
                else if (bday.Year > today.Year || bday.Year == today.Year && bday.Month > today.Month || bday.Year == today.Year && bday.Month == today.Month && bday.Day > today.Day)
                {
                    Console.WriteLine("Podałeś niepoprawną datę urodzenia");
                }
                else
                {
                    var age = today.Year - bday.Year;
                    Console.WriteLine($"Cześć {name}. Urodziłeś się w {city} i masz {age} lat.");
                }
            }
            catch (Exception)             
            {
                Console.WriteLine("Podałeś niepoprawne dane!");
            }
        }
    }
}
