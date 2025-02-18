using System.ComponentModel.DataAnnotations;
using static Assignment2_Linq.ListGenerators;

namespace Assignment2_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Element Operators


            #region Q1 : Get first Product out of Stock

            //var res = ProductList.First();

            //Console.WriteLine(res);

            #endregion

            #region Q2 : Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var res = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);

            //Console.WriteLine(res);

            #endregion

            #region Q3 :  Retrieve the second number greater than 5 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var res = Arr.Where(p => p > 5).OrderBy(p => p).ElementAt(1);

            //Console.WriteLine(res);

            #endregion

            #endregion

            #region Aggregate Operators

            #region Q1 : Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var res = Arr.Count(p => p % 2 != 0);

            //Console.WriteLine(res);

            #endregion

            #region Q2 : Return a list of customers and how many orders each has.

            //var res = CustomerList.Select(c => new { customer = c, Orders = c.Orders?.Length ?? 0 });

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q3 : Return a list of categories and how many products each has

            //var res = ProductList.GroupBy(p => p.Category).Select(p => new { Category = p.Key, Products = p.Count() });

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q4 : Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var res = Arr.Sum();

            //Console.WriteLine(res);

            #endregion

            #region Q5 : Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var res = words.Sum(word => word.Length);

            //Console.WriteLine(res);

            #endregion

            #region Q6 : Get the length of the shortest word in dictionary_english.txt

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var res = words.Min(word => word.Length);

            //Console.WriteLine(res);

            #endregion

            #region Q7 : Get the length of the longest word in dictionary_english.txt

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var res = words.Max(word => word.Length);

            //Console.WriteLine(res);

            #endregion

            #region Q8 : Get the average length of the words in dictionary_english.txt

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var res = words.Average(word => word.Length);

            //Console.WriteLine(res);

            #endregion

            #region Q9 : Get the total units in stock for each product category

            //var res = from n in ProductList
            //          group n by n.Category
            //          into grouped
            //            select new
            //            {
            //                Category = grouped.Key,
            //                TotalUnitsInStock = grouped.Sum(p => p.UnitsInStock)
            //            };

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q10 : Get the cheapest price among each category's products

            //var res = ProductList.GroupBy(p => p.Category).Select(p => new { Category = p.Key, CheapestPrice = p.Min(p => p.UnitPrice) });

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q11 : Get the products with the cheapest price in each category (Use Let)

            //var res = from p in ProductList
            //          group p by p.Category into g
            //          let cheapestProduct = g.OrderBy(p => p.UnitPrice).First()
            //          select new
            //          {
            //              Category = g.Key,
            //              CheapestProduct = cheapestProduct
            //          };

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q12 : Get the most expensive price among each category's products.

            //var res = ProductList.GroupBy(p => p.Category).Select(p => new { Category = p.Key, MostExpensive = p.Max(p => p.UnitPrice) });

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q13 : 

            #endregion

            #endregion

        }
    }
}
