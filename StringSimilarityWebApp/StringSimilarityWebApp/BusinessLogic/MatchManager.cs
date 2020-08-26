using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using F23.StringSimilarity;
using Microsoft.Ajax.Utilities;

namespace StringSimilarityWebApp.BusinessLogic
{
    public class MatchManager
    {
        public Dictionary<int, string> my_mapper = new Dictionary<int, string>()
        {
            {1, "F23.StringSimilarity.JaroWinkler, F23.StringSimilarity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" },
            {2 , "F23.StringSimilarity.Levenshtein, F23.StringSimilarity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" },
            {3, "F23.StringSimilarity.NormalizedLevenshtein, F23.StringSimilarity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" },
            {4, "F23.StringSimilarity.WeightedLevenshtein, F23.StringSimilarity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" },
            {5, "F23.StringSimilarity.Damerau, F23.StringSimilarity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" },
            {6, "F23.StringSimilarity.OptimalStringAlignment, F23.StringSimilarity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" },
            {7, "F23.StringSimilarity.LongestCommonSubsequence, F23.StringSimilarity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" },
            {8, "F23.StringSimilarity.MetricLCS, F23.StringSimilarity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" },
            {9, "F23.StringSimilarity.NGram, F23.StringSimilarity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" },
            {10, "F23.StringSimilarity.QGram, F23.StringSimilarity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" },
            {11, "F23.StringSimilarity.Cosine, F23.StringSimilarity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" },
            {12, "F23.StringSimilarity.Jaccard, F23.StringSimilarity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" },
            {13, "F23.StringSimilarity.SorensenDice, F23.StringSimilarity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" }
        };

        public string compute(int a, string s1, string s2)
        {
            string p =  my_mapper[a];
            //string stpx = typeof(p).AssemblyQualifiedName;
            Type objectType = Type.GetType( p, true);
            dynamic  instantiatedObject = Activator.CreateInstance(objectType);
            var result = instantiatedObject.Distance(s1,s2);

            return result.ToString();
        }
    }
}