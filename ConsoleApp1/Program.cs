using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "abacaxi";
            int vogal = 0;
            int consoante = 0;
            foreach (char item in a)
            {
                
                Console.WriteLine(item);
                if (item == 'a' || item == 'i')
                    vogal += 1;
                else consoante += 1;
                Console.WriteLine("qtd vogais: "+vogal);
                Console.WriteLine("qtd consoantes: "+consoante);
            }
        }
    }
}
