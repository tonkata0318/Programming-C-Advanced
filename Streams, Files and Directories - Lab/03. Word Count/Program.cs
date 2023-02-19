using System.Collections.Generic;
using System.IO;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            using (StreamReader readerForWords = new StreamReader(wordsFilePath))
            {
                using (StreamReader readerForText = new StreamReader(textFilePath))
                {
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        string[] words = readerForWords.ReadToEnd().Split(" ");
                        Dictionary<string, int> wordsIntext = new Dictionary<string, int>();
                        string[] textSplited=readerForText.ReadToEnd().Split(' ');
                        foreach (var wordIntext in textSplited)
                        {
                            foreach (var wordtoLookFor in words)
                            {
                                if (wordIntext.Contains('.'))
                                {
                                    int indexofDot = wordIntext.IndexOf('.');
                                    string newWord = wordIntext.Substring(0,indexofDot).ToLower();
                                    if (newWord == wordtoLookFor)
                                    {
                                        if (!wordsIntext.ContainsKey(wordtoLookFor))
                                        {
                                            wordsIntext.Add(wordtoLookFor, 1);
                                        }
                                        else
                                        {
                                            wordsIntext[wordtoLookFor] += 1;
                                        }
                                    }
                                }
                                else
                                {
                                    if (wordIntext.ToLower() == wordtoLookFor)
                                    {
                                        if (!wordsIntext.ContainsKey(wordtoLookFor))
                                        {
                                            wordsIntext.Add(wordtoLookFor, 1);
                                        }
                                        else
                                        {
                                            wordsIntext[wordtoLookFor] += 1;
                                        }
                                    }
                                }
                            }
                        }
                        foreach (var item in wordsIntext)
                        {
                            writer.WriteLine($"{item.Key} - {item.Value}");
                        }
                    }
                }
            }
        }
    }
}
