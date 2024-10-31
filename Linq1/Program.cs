using System.Threading;
using static Linq1.ListGenerator;
namespace Linq1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 12365;
            //int result = IntReversed.Reversed(x);
            //int y = x.Reversed();
            //Console.WriteLine(y);

            #region Filteration -- Restriction (Where)
            //var result = ProductsList.Where(P => P.UnitsInStock == 0);
            #endregion

            #region Transformation -- Projection (Select - SelectMany)

            //var result = ProductsList.Select(x => x.ProductName);

            //var result = CustomersList.SelectMany(x => x.Orders);

            //var result = ProductsList.Select(x => new { x.ProductID, x.ProductName });

            #endregion

            #region Ordering Operator
            //var result = ProductsList.OrderBy(P => P.UnitsInStock);
            //var result = ProductsList.OrderByDescending(P => P.UnitsInStock);
            #endregion

            #region Assignment 
            // 1

            //var result = ProductsList.Where(P => P.UnitPrice > 3 && P.UnitsInStock > 0);

            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Where((P, I) => P.Length < I);

            // ======================

            // 2
            //var result = ProductsList.OrderBy(P => P.ProductName);

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            // var result = Arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase).ToArray();

            //var result = ProductsList.OrderByDescending(X => X.UnitPrice);

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.OrderBy(X => X.Length).ThenBy(X => X);

            var result = ProductsList.OrderByDescending(x => x.Category).ThenByDescending(c=>c.UnitPrice);

            #endregion

            foreach (var item in result)
                Console.WriteLine(item);
        }


    }
}
