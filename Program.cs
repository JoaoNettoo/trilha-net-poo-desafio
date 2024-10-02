using DesafioPOO.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Testando a classe Nokia
        Nokia nokia = new Nokia("30207870", "Nokia 1100", "2845678456", 128);
        Console.WriteLine("Testando Nokia:");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");
        Console.WriteLine();

        // Testando a classe Iphone
        Iphone iphone = new Iphone("987654321", "iPhone 14", "2765612556", 256);
        Console.WriteLine("Testando iPhone:");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
