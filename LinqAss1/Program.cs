using C_Assignment.Data;

namespace LinqAss1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            #region 1. Find all products that are out of stock.

            //var outOfStock = ListGenerator.ProductList
            //    .Where(p => p.UnitsInStock == 0)
            //    .ToList();

            //Console.WriteLine("Products out of stock: ");
            //foreach (var product in outOfStock)
            //{

            //    Console.WriteLine(product);
            //}

            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.

            //var inStockAndCostMoreThan3 = ListGenerator.ProductList
            //    .Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00m)
            //    .ToList();

            //Console.WriteLine("Products in stock and cost more than 3.00 per unit: ");
            //foreach (var product in inStockAndCostMoreThan3)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion

            #region 3. Returns digits whose name is shorter than their value.


            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };


            //var digitsShorterThanValue = Arr
            //    .Select((name, index) => new { Name = name, Value = index })
            //    .Where(x => x.Name.Length < x.Value)
            //    .ToList();

            //Console.WriteLine("Digits whose name is shorter than their value: ");
            //foreach (var digit in digitsShorterThanValue)
            //{
            //    Console.WriteLine($"Name: {digit.Name}, Value: {digit.Value}");
            //}
            #endregion
       

       /////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            #region 1. Sort a list of products by name

            //var sortProductByName = ListGenerator.ProductList
            //    .OrderBy(p => p.ProductName)
            //    .ToList();

            //Console.WriteLine("Products sorted by name: ");
            //foreach (var product in sortProductByName)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion


            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var caseInsensitiveSort = Arr
            //    .OrderBy(word => word, StringComparer.OrdinalIgnoreCase)
            //    .ToList();
            //Console.WriteLine("Words sorted in case-insensitive order: ");
            //foreach (var word in caseInsensitiveSort)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.

            //var sortProductByUnitsInStock = ListGenerator.ProductList
            //    .OrderByDescending(p => p.UnitsInStock)
            //    .ToList();

            //Console.WriteLine("Products sorted by units in stock from highest to lowest: ");
            //foreach (var product in sortProductByUnitsInStock)
            //{
            //    Console.WriteLine(product);

            //}
            #endregion

            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var sortDigitsByLengthThenAlpha = Arr
            //    .OrderBy(word => word.Length)
            //    .ThenBy(word => word)
            //    .ToList();
            //Console.WriteLine("Digits sorted by length of their name, and then alphabetically by the name itself: ");
            //foreach (var digit in sortDigitsByLengthThenAlpha)
            //{
            //    Console.WriteLine(digit);
            //}


            #endregion

            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortByLengthThenCaseInsensitive = Arr
            //    .OrderBy(word => word.Length)
            //    .ThenBy(word => word, StringComparer.OrdinalIgnoreCase)
            //    .ToList();
            //Console.WriteLine("Words sorted first by length and then by a case insensitive sort: ");
            //foreach (var word in sortByLengthThenCaseInsensitive)
            //{
            //    Console.WriteLine(word);
            //}


            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowes

            //var sortByCategoryThenByUnitPrice = ListGenerator.ProductList
            //    .OrderBy(p => p.Category)
            //    .ThenByDescending(p => p.UnitPrice)
            //    .ToList();

            //Console.WriteLine("Products sorted first by category, and then by unit price from highest to lowest: ");

            //foreach (var product in sortByCategoryThenByUnitPrice)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortByLengthThenByCaseInsensitiveDescending = Arr
            //    .OrderBy(word => word.Length)
            //    .ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase)
            //    .ToList();

            //Console.WriteLine("Words sorted first by length and then by a case insensitive descending sort: ");
            //foreach (var word in sortByLengthThenByCaseInsensitiveDescending)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion


            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var digitsWithSecondLetterReversed = Arr
            //    .Where(word => word.Length > 1 && word[1] == 'i')
            //    .Reverse()
            //    .ToList();
            //Console.WriteLine("Digits whose second letter is 'i' in reverse order: ");
            //foreach (var digit in digitsWithSecondLetterReversed)
            //{
            //    Console.WriteLine(digit);
            //}

            #endregion

            
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            

            #region 1. Return a sequence of just the names of a list of products.

            //var productNames = ListGenerator.ProductList
            //    .Select(p => p.ProductName)
            //    .ToList();

            //Console.WriteLine("Product Names: ");
            //foreach (var name in productNames)
            //{
            //    Console.WriteLine(name);
            //}


            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var upperAndLowerCaseWords = words
            //    .Select(word => new { Upper = word.ToUpper(), Lower = word.ToLower() })
            //    .ToList();

            //Console.WriteLine("Uppercase and Lowercase versions of each word: ");
            //foreach (var item in upperAndLowerCaseWords)
            //{
            //    Console.WriteLine($"Uppercase: {item.Upper}, Lowercase: {item.Lower}");
            //}

            #endregion

            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var productProperties = ListGenerator.ProductList
            //    .Select(p => new { p.ProductName, p.Category, Price = p.UnitPrice })
            //    .ToList();

            //Console.WriteLine("Product properties (ProductName, Category, Price): ");
            //foreach (var item in productProperties)
            //{
            //    Console.WriteLine($"ProductName: {item.ProductName}, Category: {item.Category}, Price: {item.Price}");
            //}


            #endregion

            #region 4. Determine if the value of int in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr
            //  .Select((value, index) => new { Number = value, InPlace = (value == index) });

            //Console.WriteLine("Number: In-place?");
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Number}: {item.InPlace}");
            //}
            #endregion

            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var pairs = numbersA
            //    .SelectMany(a => numbersB,
            //                (a, b) => new { a, b })
            //    .Where(pair => pair.a < pair.b);

            //Console.WriteLine("Pairs where a < b:");
            //foreach (var pair in pairs)
            //{
            //    Console.WriteLine($"{pair.a} is less than {pair.b}");
            //}

            #endregion

            #region 6. Select all orders where the order total is less than 500.00.

            //var ordersLessThan500 = ListGenerator.CustomerList
            //    .SelectMany(c => c.Orders)
            //    .Where(o => o.Total < 500.00m)
            //    .ToList();

            //Console.WriteLine("Orders with total less than 500.00: ");
            //foreach (var order in ordersLessThan500)
            //{
            //    Console.WriteLine(order);
            //}


            #endregion

            #region 7. Select all orders where the order was made in 1998 or later.

            //var ordersFrom1998OrLater = ListGenerator.CustomerList
            //    .SelectMany(c => c.Orders)
            //    .Where(o => o.OrderDate.Year >= 1998)
            //    .ToList();


            //Console.WriteLine("Orders made in 1998 or later: ");
            //foreach (var order in ordersFrom1998OrLater)
            //{
            //    Console.WriteLine(order);
            //}

            #endregion

          

        }
    }
}
