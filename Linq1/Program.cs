using System.Runtime.InteropServices;
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


            // Immediate Execution

            #region Element Operators

            //var result = ProductsList.First();
            //result = ProductsList.FirstOrDefault(x => x.UnitsInStock > 1000,new Product { ProductName= "Mohamed" });
            //result = ProductsList.FirstOrDefault(new Product { ProductName = "Hamada" });
            //var result = ProductsList.ElementAt(22);
            //List<Product> ProductList = new List<Product>();
            //var result = ProductList.SingleOrDefault(x=>x.UnitPrice>1000,new Product { ProductName= "SSS"});
            //ProductsList.Single()

            #endregion

            #region Aggregate Operators

            //var result = ProductsList.Count();
            //var result = ProductsList.Max(); // must implement IComparable
            // var result = ProductsList.MaxBy(x=>x.UnitsInStock);  //  .Net 6 c# 10 
            // var result = ProductsList.Max();

            // var result = ProductsList.Sum(product => product.UnitPrice);
            // var result = ProductsList.Average(product => product.UnitPrice);

            // var result = ProductsList.Aggregate((product, product1) => product == product1 ? product1 : product);

            // Console.WriteLine(result);

            #endregion

            #region Casting Operators

            List<Product> products = ProductsList.Where(product => product.UnitsInStock == 0).ToList();
            Product[] productsArray = ProductsList.Where(product => product.UnitsInStock == 0).ToArray();
            Dictionary<long, Product> productsDictionary = ProductsList.Where(product => product.UnitsInStock == 0)
                .ToDictionary(product => product.ProductID);


            Dictionary<long, string> productNames = ProductsList.Where(product => product.UnitsInStock == 0)
                .ToDictionary(product => product.ProductID, product => product.ProductName);


            // foreach (var product in productNames)
            // {
            //     Console.WriteLine(product.Key + " ::: " + product.Value);
            // }


            HashSet<Product> productsSet = ProductsList.Where(product => product.UnitsInStock == 0).ToHashSet();
            // foreach (var VARIABLE in productsSet)
            // {
            //     Console.WriteLine(VARIABLE);
            //     
            // }

            #endregion

            // End of Immediate Operators

            #region Generation Operators

            // var result = Enumerable.Range(0, 99);
            // foreach (var VARIABLE in  result)
            // {
            //     Console.WriteLine(VARIABLE);
            // }

            // var result = Enumerable.Repeat(new Product(), 100);
            // foreach (var VARIABLE in result)
            // {
            //     Console.WriteLine(VARIABLE);
            // }

            #endregion

            #region Set Operator - Union Family

            var seq1 = Enumerable.Range(0, 100);
            var seq2 = Enumerable.Range(50, 100);

            // var result   = seq1.Union(seq2);

            // var result = seq1.Concat(seq2);
            // result = result.Distinct();

            // var result = seq1.Intersect(seq2);

            // var result = seq1.Except(seq2);


            // foreach (var num in result)
            //     
            // {
            //     Console.Write($"{num} ");
            // }
            //     

            #endregion

            #region Quantifier  -- Return Boolean

            // Console.WriteLine(ProductsList.Any());
            // Console.WriteLine(ProductsList.Any(product => product.UnitsInStock == 0)); // return true if at least one element matched condition

            #endregion

            #region Grouping Operators

            //
            // var categoryGroup = ProductsList.GroupBy(product => product.Category);
            // foreach (var category in categoryGroup )       
            // {
            //     Console.WriteLine(category.Key);
            //     foreach (var product in category)
            //     {
            //         Console.WriteLine($"\t{product}");
            //     }
            // }

            var categories = ProductsList.Where(product => product.UnitsInStock > 0)
                                        .GroupBy(product => product.Category)
                                        .Where(group => group.Count() > 10)
                                        .Select(result => new
                                        {
                                            CategoryName = result.Key,
                                            CategoryCount = result.Count()
                                        });

            // foreach (var category in categories)
            // {
            //     Console.WriteLine($"Category Name: {category.CategoryName} =====>  Count: {category.CategoryCount}");
            // }
            #endregion

            #region Partioning Operators

            int[] arr = { 6, 4, 8, 2, 1, 3, 7, 10 };
            //Take 
            // var result = arr.Take(5);
            // var result = arr.TakeLast(3);
            // var result = arr.TakeWhile((Number, Index) => Number > Index);
            
            //Skip
            // var result = arr.Skip(5);
            // var result = arr.SkipLast(3);
            // var result = arr.SkipWhile(i => i % 2 == 0);

            // foreach (var item in result)
            // {
            //     Console.WriteLine($"{item}, ");
            // }
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

            //var result = ProductsList.OrderByDescending(x => x.Category).ThenByDescending(c=>c.UnitPrice);

            #endregion

            //foreach (var item in result)
            // Console.WriteLine(result?.ProductName??"Not Available");
        }
    }
}