using System;

namespace uc2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            float dataNascimento, idade;
            Console.WriteLine("Informe seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Informe sua data de nascimento:");
            dataNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe sua idade:");
            idade = int.Parse(Console.ReadLine());
            if(idade>=18)
            {
                    Console.WriteLine("Sua senha é "+nome +dataNascimento);
            }
                        else
            {            
                    Console.WriteLine("Sua senha é "+dataNascimento +nome);
            }
        }
    }
}

