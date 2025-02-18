using System.ComponentModel.DataAnnotations;
using System.Threading;
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

            #region Q13 : Get the products with the most expensive price in each category.

            //var res = ProductList.GroupBy(p => p.Category)
            //                     .Select(g => new { Category = g.Key , MostExpensive = g.OrderByDescending(p => p.UnitPrice).First() });

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q14 : Get the average price of each category's products.

            //var res = ProductList.GroupBy(p => p.Category)
            //                     .Select(g => new { Category = g.Key, average = g.Average( p => p.UnitPrice) });

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            #region Ordering Operators

            #region Q1 : Sort a list of products by name

            //var res = ProductList.OrderBy(p => p.ProductName);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q2 : Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //CaseInsensitive caseInsensitive = new CaseInsensitive();

            //var res = Arr.OrderBy(p => p, caseInsensitive);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q3 : Sort a list of products by units in stock from highest to lowest.

            //var res = ProductList.OrderByDescending(p => p.UnitsInStock);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q4 : Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var res01 = Arr.OrderBy(p => p.Length);

            //var res02 = Arr.OrderBy(p => p);

            //foreach (var item in res01)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("=============================");

            //foreach (var item in res02)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Q5 : Sort first by-word length and then by a case-insensitive sort of the words in an array.

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //CaseInsensitive caseInsensitive = new CaseInsensitive();

            //var res = Arr.OrderBy(p => p.Length).ThenBy(p => p , caseInsensitive);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q6 : Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var res = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q7 : Sort first by-word length and then by a case-insensitive descending sort of the words in an array.

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //CaseInsensitive caseInsensitive = new CaseInsensitive();
            //                                           //added Descending only from Q5
            //var res = Arr.OrderBy(p => p.Length).ThenByDescending(p => p, caseInsensitive);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q8 : Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var res = Arr.Where(p => p[1] == 'i').ToList();

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            #region Transformation Operators

            //same as last assignment   /* Repeated */

            #region Q1 : Return a sequence of just the names of a list of products.

            //var res = ProductList.Select(p => p.ProductName);

            #endregion

            #region Q2 : Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var res = from n in words
            //          select new { UpperCase = n.ToUpper(), LowerCase = n.ToLower() };

            #endregion

            #region Q3 : Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var res = ProductList.Select(p => new {p.ProductID, p.ProductName, Price = p.UnitPrice});

            #endregion

            #region Q4 : Determine if the value of ints in an array match their position in the array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var res = Arr.Select((n, i) => $"{n} : {n == i}");

            #endregion

            #region Q5 : Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var res = from a in numbersA
            //          from b in numbersB
            //          where a < b
            //          select $"{a} is less than {b}";

            #endregion

            #region Q6 : Select all orders where the order total is less than 500.00.

            //var res = CustomerList.SelectMany(c => c.Orders).Where(o => o.Total < 500);

            #endregion

            #region Q7 : Select all orders where the order was made in 1998 or later.

            //var res = CustomerList.SelectMany(c => c.Orders).Where(o => o.OrderDate.Year >= 1998);

            #endregion

            #region ForEach
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #endregion

            #region Set Operators

            #region Q1 : Find the unique Category names from Product List

            //var res = ProductList.Select(p => p.Category).Distinct();

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q2 : Produce a Sequence containing the unique first letter from both product and customer names.

            //var res = ProductList.Select(p => p.ProductName[0]).Union(CustomerList.Select(c => c.CustomerID[0]));

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q3 : Create one sequence that contains the common first letter from both product and customer names.

            //var res = ProductList.Select(p => p.ProductName[0]).Intersect(CustomerList.Select(c => c.CustomerID[0]));

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q4 : Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var res = ProductList.Select(p => p.ProductName[0]).Except(CustomerList.Select(c => c.CustomerID[0]));

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q5 : Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //var res = ProductList.Select(p => p.ProductName.Substring(p.ProductName.Length - 3))
            //                     .Union(CustomerList.Select(c => c.CustomerID.Substring(c.CustomerID.Length - 3)));

            //foreach (var item in res)
            //    Console.WriteLine(item);

            #endregion

            #endregion

        }
    }
}
