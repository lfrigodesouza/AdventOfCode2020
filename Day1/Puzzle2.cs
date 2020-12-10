using System;
using System.Collections.Generic;
using System.IO;
using Utils;

namespace Day1
{
    public class Puzzle2 : IPuzzle
    {
        public void SolvePuzzle()
        {
            Console.WriteLine("Iniciando Puzzle2 - Day1");
            var inputValues = new List<int>();
            using var sr = new StreamReader("input.txt");
            while (!sr.EndOfStream) inputValues.Add(int.Parse(sr.ReadLine()));

            foreach (var t in inputValues)
            {
                foreach (var t1 in inputValues)
                {
                    foreach (var t2 in inputValues)
                        if (t + t1 + t2 == 2020)
                        {
                            Console.WriteLine(
                                $"Valores encontrados! {t} + {t1} + {t2} = 2020");
                            Console.WriteLine(
                                $"{t} * {t1} + {t2} = {t * t1 * t2}");
                            return;
                        }
                }
            }
        }
    }
}
