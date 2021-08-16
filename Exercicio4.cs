using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaGft
{

    public static void Executar()
    {
        Console.Write("Qual turno você trabalha?");
        String.TryParse(Console.ReadLine(), out String turno);
        switch (turno)
        {
            case "M", "manhã", "M-manhã":
                    Console.WriteLine("Bom dia!");
                break;
            case "T", "tarde", "T-tarde":
                    Console.WriteLine("Boa tarde!");
                break;
            case "N", "noite", "N-noite":
                    Console.WriteLine("Boa noite!");
                break;
            default:
                Console.WriteLine("Valor Inválido");
                break;
        }
    }