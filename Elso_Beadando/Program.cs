﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elso_Beadando
{
    class Program
    {
        static List<int> lista = new List<int>();
        //**var end
        static void Main(string[] args)
        {
            feladat1();
            Console.ReadLine();
        }
        //**Main end
        static void feladat1()
        {
            int max = 0;        
            //var end
            Console.WriteLine("Adja meg hány darab számot fog megadni.");            
            try
            {
                int dbszam;
                dbszam = int.Parse(Console.ReadLine());
                Console.WriteLine("Adja meg a számokat pls!");
                for (int i = 0; i < dbszam; i++)
                {
                    lista.Add(int.Parse(Console.ReadLine()));
                }
                int min = lista[0];
                for (int i = 0; i < lista.Count; i++)
                {
                    if (max < lista[i])
                    {
                        max = lista[i];
                    }
                    if (min > lista[i])
                    {
                        min = lista[i];
                    }
                }
                Console.WriteLine("A legnagyobb szám a {0} volt", max);
                Console.WriteLine("A legkisebb szám a {0} volt", min);
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nem számot adtál meg, a program most leáll. Nyomj ENTER billentyűt amígy a program kilép.");
                Console.ResetColor();
                //Console.ReadKey();
            }      
        }
        
    }
}
