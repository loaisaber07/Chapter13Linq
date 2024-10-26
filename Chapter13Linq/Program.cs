using System.Collections;

namespace Chapter13Linq; 


    internal class Program
    {
        static void Main(string[] args)
    {
        #region one
        //        int[] arrayNumber = new int[] { 1, 4, 5, 6, 7, 4, 23, 5, 654, 241, 4, 1, 0 };
        //        IEnumerable<int> Enum = arrayNumber.OfType<int>(); // Using to convert nonGeneric to IEnumerable
        //        var result = arrayNumber
        //            .Where(s => s > 10).Select(s => s);  
        //foreach (var item in result)
        //        {
        //            Console.WriteLine(item);
        //        }
        //        arrayNumber[0] = 100; 
        //        foreach (var item in result)
        //        {
        //            Console.WriteLine(item);
        //        }
        //        List<int> anotherArray = new() { 2, 545, 567, 5, 67, 3, 5, 2, 13, 13, 123, 34 }; 
        //        var result2 = anotherArray
        //            .Where(s => s > 10)
        //            .Select(s => s);
        //        foreach (var item in result2)
        //        {
        //            Console.WriteLine(item);
        //        }
        //        anotherArray.Add(100);
        //        Console.WriteLine("*********************************************** \n");
        //        foreach (var item in result2)
        //        {
        //            Console.WriteLine(item);
        //        }
        //        Console.WriteLine("*********************************************** \n");
        //        var test = anotherArray.Where(s => s < 0).Select(s => s);
        //        foreach (var item in test.DefaultIfEmpty(0))
        //        {
        //            Console.WriteLine(item);
        //        }
        //        ArrayList array = new() { 1, 3, 5, 7, 8, 3, new Program() };
        //        IEnumerable<Program> c = array.OfType<Program>();
        //        foreach (var item in c)
        //        {
        //            Console.WriteLine(c);
        //        }
        //        int? x = default(int?);
        //        if (x is null)
        //        {
        //            Console.WriteLine("is Null Now ");
        //        }
        #endregion
        #region Paging Data with Range
        //List<string> Names = new() { "loai", "amir", "islam", "tyseer", "moayed", "yassmine", "eman" };
        //var lastTwo = Names.Take(..^2);
        //foreach (var item in lastTwo)
        //{
        //    Console.WriteLine(item);

        //}

        #endregion

        #region Selector 
        //List<string> strings    = new() { "loai","loai", "amir", "islam", "tyseer", "moayed", "yassmine", "eman" };
        //List<string> strings2 = new() { "loai","loai", "sakr", "yassmine", "ragab" };
        //var distinctyby = strings.DistinctBy(s=>s);
        //foreach (var item in distinctyby)
        //{
        //    Console.WriteLine(item);
        //}

        //var unionBy = strings.UnionBy(strings2, s => s);
        //Console.WriteLine("*********************************************** \n");
        //foreach (var item in unionBy)
        //{
        //    Console.WriteLine(item);
        //}
        //var instersectBy =strings.IntersectBy(strings2, s => s);
        //Console.WriteLine("*********************************************** \n");
        //foreach (var item in instersectBy)
        //{
        //    Console.WriteLine(item);
        //} 
        //var exceptBy = strings.ExceptBy(strings2, s => s);
        //Console.WriteLine("*********************************************** \n");
        //foreach (var item in exceptBy)
        //{
        //    Console.WriteLine(item);
        //} 
        #endregion

        #region Aggregation Function
        List<int> collection = new() { 10, 2, 6, 3, 123, 657, 213, 9, 1, 5 };

        #endregion

    }
}

