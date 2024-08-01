using System.Collections;
using System.Runtime.InteropServices;

namespace AdvancedCsharp2
{
    internal class Program
    {
        //public static int SumArrayList(ArrayList arrayList)
        //{
        //    int Sum = 0;
        //    if (arrayList is not null)

        //        for (int i = 0; i < arrayList.Count; i++)

        //            Sum += (int)arrayList[i];

        //    return Sum;

        //}

    //    public static int SumList(List<int> list)
    //{
    //    int Sum = 0;
    //    if (list is not null)

    //        for (int i = 0; i < list.Count; i++)

    //            Sum += list[i];

    //    return Sum;

    //}
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



            //ArrayList arrayList = new ArrayList(5);
            //Console.WriteLine($"Count of arrayList = {arrayList.Count} , Capacity of arrayList = {arrayList.Capacity}");
            //arrayList.Add(6);
            //Console.WriteLine("After Adding the 6th Element");
            //Console.WriteLine($"Count of arrayList = {arrayList.Count} , Capacity of arrayList = {arrayList.Capacity}");

            //arrayList.TrimToSize();
            //Console.WriteLine("After Trim");
            //Console.WriteLine($"Count of arrayList = {arrayList.Count} , Capacity of arrayList = {arrayList.Capacity}");

            //int Result = SumArrayList(arrayList);
            //Console.WriteLine(Result);
            #endregion
            #region Generic Collections - List
            //List<int> Numbers = new List<int>();
            //Console.WriteLine($"Count of List = {Numbers.Count}, Capcity of List = {Numbers.Capacity}");
            //Numbers.Add(1);
            //Console.WriteLine("After Adding First Element");
            //Console.WriteLine($"Count of List = {Numbers.Count}, Capcity of List = {Numbers.Capacity}");//1 -4
            //Numbers.AddRange(new int[] { 2, 3, 4 });
            //Console.WriteLine("After Adding Full Capacity of the List");
            //Console.WriteLine($"Count of List = {Numbers.Count}, Capcity of List = {Numbers.Capacity}");//4 -4
            //Numbers.Add(5);
            //Console.WriteLine("After Adding the 5th Element");
            //Console.WriteLine($"Count of List = {Numbers.Count}, Capcity of List = {Numbers.Capacity}");//5 -8
            //Numbers.TrimExcess();
            //Console.WriteLine("After Trim");
            //Console.WriteLine($"Count of arrayList = {Numbers.Count} , Capacity of arrayList = {Numbers.Capacity}");

            //List<int> Numbers = new List<int>(5) { 1,2,3,4,5};
            //Console.WriteLine($"Count of arrayList = {Numbers.Count} , Capacity of arrayList = {Numbers.Capacity}");//5-5
            //Numbers.Add(6);
            //Console.WriteLine("After adding the 6th Element");
            //Console.WriteLine($"Count of arrayList = {Numbers.Count} , Capacity of arrayList = {Numbers.Capacity}");//6-10

            //foreach (int item in Numbers) 
            //{
            //    Console.WriteLine(item);
            //}
            //Numbers[3] = 40;
            //for (int i =0; i<Numbers.Count;i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            //int Result = SumList(Numbers);
            //Console.WriteLine($"Result {Result}");
            #endregion
            #region List Method
            //List<int> Numbers = new List<int>(4){ 1,2,3,4};
            //Console.WriteLine($"Count of List = {Numbers.Count}, Capcity of List = {Numbers.Capacity}");
            //Numbers.Add(5);
            //Numbers.AddRange(new int[] { 6, 7 });
            //Console.WriteLine($"Count of List = {Numbers.Count}, Capcity of List = {Numbers.Capacity}");
            //foreach (int item in Numbers) 
            //    Console.Write($"{item}");
            //Console.WriteLine("\n=================================");
            //Numbers.Insert(6,8);
            //foreach (int item in Numbers)
            //    Console.Write($"{item}");
            //Console.WriteLine("\n=================================");
            //Numbers.InsertRange(4, new int[] { 9, 10 });
            //foreach (int item in Numbers)
            //    Console.Write($"{item}");
            //Console.WriteLine("\n=================================");
            //int index = Numbers.BinarySearch(3);
            //Console.WriteLine($"index of 3 = {index}");
            //int index = Numbers.BinarySearch(9);
            //Console.WriteLine($"index of 9 = {index}");
            //Numbers.Clear();
            //Console.WriteLine($"Count of List = {Numbers.Count}, Capcity of List = {Numbers.Capacity}");

            //Console.WriteLine(Numbers.Contains(9)) ;
            //Console.WriteLine(Numbers.Contains(100));


            //List<int> Numbers = new List<int>(4) { 1, 2, 3, 4 };
            //int[] array = new int[10];
            //Numbers.CopyTo(array);
            //Numbers.CopyTo(array,3);
            //Numbers.CopyTo(1,array, 5,3);
            //foreach (int i in array) 
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine($"Count of List = {Numbers.Count}, Capcity of List = {Numbers.Capacity}");
            //Numbers.EnsureCapacity(4);
            //Console.WriteLine(Numbers.EnsureCapacity(4));
            //Numbers.EnsureCapacity(20);
            //Console.WriteLine(Numbers.EnsureCapacity(20));
            //Console.WriteLine($"Count of List = {Numbers.Count}, Capcity of List = {Numbers.Capacity}");
            //int index = Numbers.IndexOf(3);
            //Console.WriteLine(index);

            //foreach (int i in Numbers) 
            //{
            //    Console.WriteLine(i);
            //}
            //Numbers.Reverse();
            //Console.WriteLine("======================");
            //foreach (int i in Numbers) 
            //{
            //    Console.WriteLine(i);
            //}


            #endregion
            #region LinkedList
            LinkedList<int> Linkedlist = new LinkedList<int>();
            Console.WriteLine(Linkedlist.Count);
            Linkedlist.AddLast(1);
            Linkedlist.AddLast(2);
            Console.WriteLine(Linkedlist.Count);
            LinkedListNode<int> AfterNode = Linkedlist.Find(1);
            Linkedlist.AddAfter(AfterNode,5);
            Linkedlist.AddBefore(Linkedlist.Find(2), 10);
            Console.WriteLine(Linkedlist.Count);
            foreach (int i in Linkedlist)
                Console.WriteLine(i);


            #endregion
        }
    }
}
