using System;

namespace Interpretador.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "     __  __      __  __ __   __  __  __ \n" +
                           "  |  __| __||__||__ |__   | |__||__||  |\n" +
                           "  | |__  __|   | __||__|  | |__| __||__|\n";

            System.IO.StringReader leitorDeCodigos = new System.IO.StringReader(texto);

            string linha1 = leitorDeCodigos.ReadLine();
            string linha2 = leitorDeCodigos.ReadLine();
            string linha3 = leitorDeCodigos.ReadLine();

            char[] primeiraLinha = linha1.ToCharArray();
            char[] segundaLinha = linha2.ToCharArray();
            char[] terceiraLinha = linha3.ToCharArray();

            string L1 = "";
            string L2 = "";
            string L3 = "";

            int contador = 0;

            for (int i = 0; i < 40;i++)
            {
                L1 += primeiraLinha[i];
                L2 += segundaLinha[i];
                L3 += terceiraLinha[i];

                if (L1 == "    " && L2 == "  | " && L3 == "  | ")
                {
                    Console.Write("1"); //1
                }
                if (L1 == " __ " && L2 == " __|" && L3 == "|__ ")
                {
                    Console.Write("2"); //2
                }
                if (L1 == " __ " && L2 == " __|" && L3 == " __|")
                {
                    Console.Write("3"); //3
                }
                if (L1 == "    " && L2 == "|__|" && L3 == "   |")
                {
                    Console.Write("4"); //4
                }
                if (L1 == " __ " && L2 == "|__ " && L3 == " __|")
                {
                    Console.Write("5"); //5
                }
                if (L1 == " __ " && L2 == "|__ " && L3 == "|__|")
                {
                    Console.Write("6"); //6
                }
                if (L1 == "__  " && L2 == "  | " && L3 == "  | ")
                {
                    Console.Write("7"); //7
                }
                if (L1 == " __ " && L2 == "|__|" && L3 == "|__|")
                {
                    Console.Write("8"); //8
                }
                if (L1 == " __ " && L2 == "|__|" && L3 == " __|")
                {
                    Console.Write("9"); //9
                }
                if (L1 == " __ " && L2 == "|  |" && L3 == "|__|")
                {
                    Console.Write("0"); //0
                }

                contador += 1;

                if (contador == 4)
                {
                    L1 = "";
                    L2 = "";
                    L3 = "";
                    contador = 0;
                }






            }
                




        }
    }
}
