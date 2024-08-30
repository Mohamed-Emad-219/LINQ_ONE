using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using static LINQ_ONE.ListGenerator;
namespace LINQ_ONE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region All product out of stock
            //var Result = ProductsList.Where(p => p.UnitsInStock == 0);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region all products that are in stock and cost more than 3.00 per unit.
            //var Result = ProductsList.Where(p => p.UnitPrice > 3 && p.UnitsInStock > 0);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Returns digits whose name is shorter than their value.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result = Arr.Where((a, i) => a.Length < i);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Sort a list of products by units in stock from highest to lowest. 
            //var Result = ProductsList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region . Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //var Result = Arr.OrderBy(d => d.Length).ThenBy(d => d);
            //     foreach (var item in Result)
            //     {
            //         Console.WriteLine(item);
            //     } 
            #endregion

            #region  5.Sort first by word length and then by a case -insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            // var Result = Arr.OrderBy(d => d.Length).ThenBy(d => d,StringComparer.OrdinalIgnoreCase);
            #endregion

            #region Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var Result = ProductsList.OrderByDescending(p => p.Category)
            //                         .ThenByDescending(p => p.UnitPrice);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region  Sort first by word length and then by a case-insensitive descending sort of the words in an array.
            // string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //  var Result = Arr.OrderByDescending(d => d.Length).ThenByDescending(d => d,StringComparer.OrdinalIgnoreCase);
            #endregion

            #region Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Where(i => i.Length > 1 && i[1] == 'i')
            //                .Reverse().ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //} 
            #endregion
        }
    }
}  
