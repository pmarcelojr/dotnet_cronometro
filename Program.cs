using System;

namespace dotnet_cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int hrs=0; hrs<=24; hrs++ ){
                for(int min=0; min<60; min++){
                    for(int seg=0; seg<60; seg++){
                        System.Console.WriteLine($"{hrs}:{min}:{seg}");
                    }
                }
            }
        }
    }
}
