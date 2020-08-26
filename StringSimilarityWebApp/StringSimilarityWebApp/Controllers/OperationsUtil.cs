using System;
using System.Collections.Generic;
using System.Text;
using F23.StringSimilarity;
using System.IO;
using System.Web;

namespace StringSimilarityWebApp
{
    class OperationsUtil
    {
        static double similarity_threshold = 0.80;
        static double distance_threshold = 0.50;
        static public Dictionary<string, double> similarity_d = new Dictionary<string, double>();
        static public Dictionary<string, double> distance_d = new Dictionary<string, double>();
        public static double GetSimilarity(string s1, string s2)
        {
            var compute = new JaroWinkler();
            return compute.Similarity(s1, s2);
        }

        public static double GetDistance(string s1, string s2)
        {
            var compute = new Jaccard();
            return compute.Distance(s1, s2);
        }

        public static void CheckAddToSimilarity(string s1, double val)
        {
            if (val > similarity_threshold)
            {
                similarity_d[s1] = val;
            }
        }

        public static void CheckAddToDistance(string s1, double val)
        {
            if (val < distance_threshold)
            {
                distance_d[s1] = val;
            }

        }

        public static void ComputeThresholds(string s1)
        {
            similarity_d.Clear();
            distance_d.Clear();
            string appdatafolder = Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, "App_Data");
            string[] sites = File.ReadAllLines(appdatafolder+@"\Domains.txt");
            foreach (string site in sites)
            {
                double similarity = GetSimilarity(s1, site);
                CheckAddToSimilarity(site, similarity);
                double distance = GetDistance(s1, site);
                CheckAddToDistance(site, distance);
            }
        }
    }
}
