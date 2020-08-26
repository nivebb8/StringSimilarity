using System;
using System.Collections.Generic;
using System.IO;
using F23.StringSimilarity;

namespace StringSimilarityOut
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("########################################################################################################");
            Console.WriteLine("## _     _                         _             _        _____                                       ##");
            Console.WriteLine("##| |   | |                       | |           | |      (____ \\       _              _               ##");
            Console.WriteLine("##| |__ | | ___  ____   ___   ____| |_   _ ____ | | _     _   \\ \\ ____| |_  ____ ____| |_  ___   ____ ##");
            Console.WriteLine("##|  __)| |/ _ \\|    \\ / _ \\ / _  | | | | |  _ \\| || \\   | |   | / _  )  _)/ _  ) ___)  _)/ _ \\ / ___)##");
            Console.WriteLine("##| |   | | |_| | | | | |_| ( ( | | | |_| | | | | | | |  | |__/ ( (/ /| |_( (/ ( (___| |_| |_| | |    ##");
            Console.WriteLine("##|_|   |_|\\___/|_|_|_|\\___/ \\_|| |_|\\__  | ||_/|_| |_|  |_____/ \\____)\\___)____)____)\\___)___/|_|    ##");
            Console.WriteLine("##                          (_____| (____/|_|                                                         ##");
            Console.WriteLine("########################################################################################################");
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Please enter the domain name");
                var homoglyph = Console.ReadLine().ToString();
                Console.WriteLine($"Detecting Homoglyph for {homoglyph} across top registered domains.....");
                OperationsUtil.ComputeThresholds(homoglyph);
                Console.WriteLine("###########################################################");
                Console.WriteLine("##         Homoglyph site detected by similairty         ##");
                Console.WriteLine("###########################################################");
                foreach (var site in OperationsUtil.similarity_d)
                {
                    Console.WriteLine($"## {site.Key,-25} : {site.Value,25} ##");
                }
                Console.WriteLine("###########################################################");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("###########################################################");
                Console.WriteLine("##          Homoglyph site detected by distance          ##");
                Console.WriteLine("###########################################################");
                foreach (var site in OperationsUtil.distance_d)
                {
                    Console.WriteLine($"## {site.Key,-25} : {site.Value,25} ##");
                }
                Console.WriteLine("###########################################################");
            }
        }

    }
}