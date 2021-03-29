﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipInfo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var searchParameters = new ShipInfo
            {
                Size = "Medium",
                Country = "United States",
                Color = new List<string> { "White", "Brown", "Black" },
                Page = 0,
                PageSize = 5
            };
            Console.WriteLine("Type any key to begin search");
            var ships = ShipInfo.LoadSips();

            while (Console.ReadKey().KeyChar != 'q')
            {
                Console.WriteLine($"Page: {searchParameters.Page}");
                ships.Search(searchParameters).ToList().ForEach(b =>
                {
                    Console.WriteLine($"Common Name: {b.CommonName}");
                });

                searchParameters.Page++;
            }
        }
    }
}