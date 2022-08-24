//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            for (int i = 0; i < 10000000; i++)
            {
                Train train =new Train($"{i}");
                //train.StartEngines();
            }
            Train t1 =new Train("Last Train To London");
            Train t2 =new Train("Last Train To London");
            Train t3 =new Train("Runaway Train");
            Console.WriteLine(Train.Count);
            
        }
    }
}