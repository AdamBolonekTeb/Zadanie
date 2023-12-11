using System;
using System.IO;
class Program
{
    static void Main()
    {
        Console.Write("Podaj ścieżkę do pliku: ");
        string filePath = Console.ReadLine();
        if (File.Exists(filePath))
        {
            string content = File.ReadAllText(filePath);
            Console.WriteLine("Zawartość pliku:");
            Console.WriteLine(content);
        }
        else
        {
            Console.WriteLine("Plik nie istnieje. Tworzenie nowego pliku.");
            using (StreamWriter sw = File.CreateText(filePath))
            {
                Console.WriteLine("Wprowadzaj tekst (wpisz 'END;¡' aby zakończyć):");
                string line;
                do
                {
                    line = Console.ReadLine();
                    if (line != "END;/")
                        sw.WriteLine(line);
                } while (line != "END;/");
            }
            Console.WriteLine("Zapisano tekst do pliku.");
        }
    }
}
