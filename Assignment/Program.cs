using System.Collections;

namespace Assignment
{
    internal class Program
    {
        //public static ArrayList reverse(ArrayList arrayList) 
        //{
        //    for (int i = 0; i < arrayList.Count / 2; i++) 
        //    {
        //        int temp = (int)arrayList[i];
        //        arrayList[i] = arrayList[arrayList.Count - i - 1];
        //        arrayList[arrayList.Count - i - 1] = temp;
        //    }
        //    return arrayList;
        //}
        static void Main(string[] args)
        {
            #region Part 1
            /*
             1.Arraylist
            hold various data types in one place 




             */
            //ArrayList arrayList = new ArrayList();
            // arrayList.Add(1);
            // arrayList.Add(2);
            // Console.WriteLine($"Count {arrayList.Count} Capacity {arrayList.Capacity}");

            #endregion


            #region Part 2

            #region Q1
            //ArrayList arraylist = new ArrayList(4) { 1,2,3,4};
            //foreach (int i in reverse(arraylist)) 
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Q2
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<int> evenNumbers = new List<int>();
            for (int i = 0; i < list.Count; i++) 
            {
                if (list[i]%2==0)
                {
                    evenNumbers.Add(list[i]);
                }
            }

            #endregion

            #region Q3
            FixedSizeList<int> numbers = new FixedSizeList<int>(3);
            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(2); 
            numbers.Add(3);

            Console.WriteLine(numbers[1]);
            

            #endregion

            #endregion



        }
    }
}
