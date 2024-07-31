using System.Collections;

namespace AdvancedCsharp2
{
    internal class Program
    {
        public static int SumArrayList(ArrayList arrayList) 
        {
            int Sum = 0;
            if (arrayList is not null) 
            
                for (int i = 0;  i< arrayList.Count;i++)
                
                    Sum += (int)arrayList[i];
                
            return Sum;
        
        }
        static void Main(string[] args)
        {
            #region Part 01 NonGeneric Collections - ArrayList
            //ArrayList arrayList = new ArrayList();
            //   Console.WriteLine( $"Count of arrayList = {arrayList.Count} , Capacity of arrayList = {arrayList.Capacity}");
            //   arrayList.Add(1);
            //   Console.WriteLine("After adding Element");
            //   Console.WriteLine( $"Count of arrayList = {arrayList.Count} , Capacity of arrayList = {arrayList.Capacity}");
            //   arrayList.AddRange(new int[] {2,3,4});
            //   Console.WriteLine($"Count of arrayList = {arrayList.Count} , Capacity of arrayList = {arrayList.Capacity}");
            //   arrayList.Add(5);
            //   Console.WriteLine("After Adding the 5th Element");
            //   Console.WriteLine($"Count of arrayList = {arrayList.Count} , Capacity of arrayList = {arrayList.Capacity}");



            ArrayList arrayList = new ArrayList(5);
            Console.WriteLine($"Count of arrayList = {arrayList.Count} , Capacity of arrayList = {arrayList.Capacity}");
            arrayList.Add(6);
            Console.WriteLine("After Adding the 6th Element");
            Console.WriteLine($"Count of arrayList = {arrayList.Count} , Capacity of arrayList = {arrayList.Capacity}");

            arrayList.TrimToSize();
            Console.WriteLine("After Trim");
            Console.WriteLine($"Count of arrayList = {arrayList.Count} , Capacity of arrayList = {arrayList.Capacity}");

            int Result = SumArrayList(arrayList);
            Console.WriteLine(Result);
            #endregion

        }
    }
}
