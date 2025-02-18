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
        }
    }
}
