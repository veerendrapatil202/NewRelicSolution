using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRelic
{
    public class Find
    {
        // This method will return the most common three word sequences in descending order of frequency
        // Parameters: fileName: Name of the text File with complete path, count: how many of the most common three word sequences
        public IEnumerable<KeyValuePair<string, int>> FindMostCommonSequences(string fileName, int count)
        {
            try
            {
                if (!File.Exists(fileName))
                    return Enumerable.Empty<KeyValuePair<string, int>>();
                
                var words = GetWords(fileName);
                var three_word_sequences = new Dictionary<string, int>();
                for (int i = 0; i < words.Count() - 2; i++)
                {
                    // if the key (word Sequency) already exists then use its value else zero and then increment it by 1
                    three_word_sequences[words[i] + " " + words[i + 1] + " " + words[i + 2]] = 
                        three_word_sequences.TryGetValue(words[i] + " " + words[i + 1] + " " + words[i + 2], out int value) ? value + 1: 1;
                }
                var wordSequences = three_word_sequences.OrderByDescending(key => key.Value).Take(count);
                return wordSequences;
            }
            catch
            {
                throw;
            }
        }

        // This method will return all the words in a given text file
        // Paramater: fileName: Name of the text File with complete path
        private static List<string> GetWords(string fileName)
        {
            try
            {
                var builder = new StringBuilder();
                List<string> words = new List<string>();

                // Using Stream Reader to save on memory for large files
                using (var reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        char c = (char)reader.Read();

                        // Reading individual characters so that to have full control on any type of conditions to identify it as word separator
                        // Only the chars in the below condition will be treated as part of a word
                        if (char.IsLetterOrDigit(c) || c == '_' || c == '\'' || c == '-')
                        {
                            builder.Append(char.ToLower(c)); // To make it case insensitive
                        }
                        // Only the chars in the below condition will be treated as word separator
                        else if ( c == ' ' || c == '\n')
                        {
                            if (builder.Length > 0)
                            {
                                words.Add(builder.ToString());
                                builder.Clear();
                            }
                        }
                    }
                }
                return words;
            }
            catch
            {
                throw;
            }
        }
    }
}
