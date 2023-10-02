using System.Xml.Linq;

namespace Problema_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstnumber = ReadNumberFromKeyboard("Va rog sa introduceti primul numar: ");
            int secondnumber = ReadNumberFromKeyboard("Va rog sa introduceti al doilea numar: ");

            if (secondnumber == 0)
            {
                Console.WriteLine("Impartirea prin zero nu este permisa.");
                return;  
            }

            int rezultatintreg = firstnumber / secondnumber;
            int rest = firstnumber % secondnumber;

            if (rest == 0)
            {
                Console.WriteLine("Impartirea poate fi facuta exact. Rezultatul intreg este: " + rezultatintreg);
            }
            else
            {
                Console.WriteLine("Impartirea nu poate fi facuta exact. Rezultatul intreg este: " + rezultatintreg + " iar restul este: " + rest);
            }

            //nu vedeam rezultatul fara asta
            Console.ReadLine();
        }

        static int ReadNumberFromKeyboard(string label)
        {
            bool canConvert = false;
            while (!canConvert)
            {
                Console.Write(label);
                string textRead = Console.ReadLine();

                canConvert = int.TryParse(textRead, out int result);
                if (canConvert)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Textul " + textRead + " nu reprezinta un numar.");
                }
            }

            return 0;
        }
    }
}