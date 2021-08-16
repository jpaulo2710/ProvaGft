using System;

namespace ProvaGft
    // Misturei um pouco de Java e C#, devido ao tempo não consegui traduzir tudo para c# espero que considerem =)
{
    public class Exercicio1

    {
        int idades[] = new int[10];
        int sub14 = 0, sub29 = 0, sub44 = 0, sub59 = 0, sub60 = 0;
        scanner ler = new scanner(Console.in);
        for (int i = 0; i<idades.length; i++) {
            Console.WriteLine("informe a idade");
            idades[i] = ler.nestInt();
            

            if (idades[i] <= 14) {
            sub14++;
            }
    else if (idades[i] >= 15 && idades[i] <= 29)
        sub29++;
        else if (idades[i] >= 30 && idades[i] <= 44)
        sub44++;
        else if (idades[i] >= 45 && idades[i] <= 59)
        sub59++;
        else if (idades[i] > 60)
        sub60++;

        }

    Console.WriteLine("Pessoas até 14: " + sub14);
    Console.WriteLine("Pessoas de 15 até 20: " + sub29);
    Console.WriteLine("Pessoas de 30 até 44: " + sub44);
    Console.WriteLine("Pessoas de 45 até 59: " + sub59);
    Console.WriteLine("Pessoas acima de 60: " + sub60);


}













