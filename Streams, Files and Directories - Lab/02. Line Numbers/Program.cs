﻿using System.IO;
using System;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    int count = 1;
                    string line = reader.ReadLine();
                    while (line!=null)
                    {

                        writer.WriteLine($"{count++}. {line}");
                        line= reader.ReadLine();
                    }
                }
            }
        }
    }
}
