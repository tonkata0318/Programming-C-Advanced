using System;
using System.IO;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using (StreamReader reader1 = new StreamReader(firstInputFilePath))
            {
                using (StreamReader reader2 = new StreamReader(secondInputFilePath))
                {
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        string firstInput = reader1.ReadLine();
                        string secondInput = reader2.ReadLine();
                        while (firstInput!=null||secondInput!=null)
                        {
                            if (firstInput == null)
                            {

                            }
                            else
                            {
                                writer.WriteLine(firstInput);
                            }
                            if (secondInput==null)
                            {

                            }
                            else
                            {
                                writer.WriteLine(secondInput);
                            }
                            firstInput = reader1.ReadLine();
                            secondInput = reader2.ReadLine();
                        }
                    }
                }
            }
        }
    }
}
