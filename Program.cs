using System;

namespace aumento
{
    class Program
    {
        static void Main(string[] args)
        {
            float sal;
            float nsal;
            Console.WriteLine("Digite o seu salário atual: ");
            sal = float.Parse(Console.ReadLine());
            if (sal < 500)
            {
                nsal = (30 / 100) * sal;
                Console.WriteLine("você receberá um aumento de 50%");
                Console.WriteLine("Seu novo salário é: "+nsal+"$S");
            }
            else
            {
                Console.WriteLine("seu salário irá permanecer o mesmo.");
            }
        }
    }
}
