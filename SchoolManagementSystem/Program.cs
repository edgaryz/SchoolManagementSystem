namespace MyProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MokiniuValdymas mokiniuValdymas = new MokiniuValdymas();
            MokytojuValdymas mokytojuValdymas = new MokytojuValdymas();
            MokyklaService mokyklaService = new MokyklaService(mokiniuValdymas, mokytojuValdymas);

            while (true)
            {
                Console.WriteLine("1. Pridėti mokinį");
                Console.WriteLine("2. Pridėti mokytoją");
                Console.WriteLine("3. Pridėti pažymį");
                Console.WriteLine("4. Peržiūrėti visus mokinius");
                Console.WriteLine("5. Peržiūrėti visus mokytojus");
                Console.WriteLine("6. Peržiūrėti mokinio pažymius");
                Console.WriteLine("0. Išeiti");
                Console.Write("Pasirinkite veiksmą: ");
                string pasirinkimas = Console.ReadLine();

                try
                {
                    switch (pasirinkimas)
                    {
                        case "1":
                            Console.Write("Įveskite mokinio vardą: ");
                            string mokinioVardas = Console.ReadLine();
                            Console.Write("Įveskite mokinio pavardę: ");
                            string mokinioPavarde = Console.ReadLine();
                            Console.Write("Įveskite mokinio amžių: ");
                            int amzius = int.Parse(Console.ReadLine());
                            Console.Write("Įveskite mokinio klasę: ");
                            string klase = Console.ReadLine();
                            mokyklaService.PridetiMokini(new Mokinys(mokinioVardas, mokinioPavarde, amzius, klase));
                            break;
                        case "2":
                            Console.Write("Įveskite mokytojo vardą: ");
                            string mokytojoVardas = Console.ReadLine();
                            Console.Write("Įveskite mokytojo pavardę: ");
                            string mokytojoPavarde = Console.ReadLine();
                            Console.Write("Įveskite mokytojo dėstomą dalyką: ");
                            string dalykas = Console.ReadLine();
                            mokyklaService.PridetiMokytoja(new Mokytojas(mokytojoVardas, mokytojoPavarde, dalykas));
                            break;
                        case "3":
                            Console.Write("Įveskite mokinio vardą: ");
                            mokinioVardas = Console.ReadLine();
                            Console.Write("Įveskite mokinio pavardę: ");
                            mokinioPavarde = Console.ReadLine();
                            Console.Write("Įveskite mokytojo vardą: ");
                            mokytojoVardas = Console.ReadLine();
                            Console.Write("Įveskite mokytojo pavardę: ");
                            mokytojoPavarde = Console.ReadLine();
                            Console.Write("Įveskite dalyką: ");
                            dalykas = Console.ReadLine();
                            Console.Write("Įveskite pažymį: ");
                            int pazymysVertinimas = int.Parse(Console.ReadLine());
                            Pazymys pazymys = new Pazymys(dalykas, DateTime.Now, pazymysVertinimas);
                            mokyklaService.PridetiPazymi(mokinioVardas, mokinioPavarde, mokytojoVardas, mokytojoPavarde, pazymys);
                            break;
                        case "4":
                            var mokiniai = mokyklaService.GautiVisusMokinius();
                            foreach (var mokinys in mokiniai)
                            {
                                Console.WriteLine(mokinys.GautiInfo());
                            }
                            break;
                        case "5":
                            var mokytojai = mokyklaService.GautiVisusMokytojus();
                            foreach (var mokytojas in mokytojai)
                            {
                                Console.WriteLine(mokytojas.GautiInfo());
                            }
                            break;
                        case "6":
                            Console.Write("Įveskite mokinio vardą: ");
                            mokinioVardas = Console.ReadLine();
                            Console.Write("Įveskite mokinio pavardę: ");
                            mokinioPavarde = Console.ReadLine();
                            var pazymiai = mokyklaService.GautiMokinioPazymius(mokinioVardas, mokinioPavarde);
                            foreach (var p in pazymiai)
                            {
                                Console.WriteLine($"{p.Dalykas}, {p.IvykdymoData}, {p.PazymysVertinimas}");
                            }
                            break;
                        case "0":
                            return;
                        default:
                            Console.WriteLine("Neteisingas pasirinkimas.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Klaida: {ex.Message}");
                }

                Console.WriteLine();
            }
        }
    }
}