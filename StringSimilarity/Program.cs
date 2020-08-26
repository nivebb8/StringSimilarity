using System;
using F23.StringSimilarity;

namespace StringSimilarity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var a = new Levenshtein();
            var b = new NormalizedLevenshtein();
            var c = new Damerau();
            var d = new JaroWinkler();
            Console.WriteLine(d.Similarity("abc", "abd"));
        }
    }
}
