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
            When we use ArrayList, it often requires us to box or unbox the objects that we are accessing to avoid any errors. 
            time Complexity:
            Accessing elements: ArrayList access time complexity is O(1) because elements are stored next to each other in memory.
            Business Case : List of different datatypes of it's items 
             */
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1); // integer
            arrayList.Add(2);
            arrayList.Add("3"); // string
            Console.WriteLine(arrayList[2]);
            Console.WriteLine($"Count {arrayList.Count} Capacity {arrayList.Capacity}");//3 4

            /*
           2.List
          A list is a dynamic-size collection of elements of the same type
          When we use ArrayList, it often requires us to box or unbox the objects that we are accessing to avoid any errors. 
          time Complexity:
          Accessing elements: List access time complexity is O(n) because the list must be traversed to find the desired element.
          Business Case :  a collection of strongly typed objects. These objects can be easily accessed using their respective index. 
   */
            List<int> list = new List<int>();
            list.Add(1); // allows only integer values 
            list.Add(2);
            list.Add(3);
            Console.WriteLine(list[2]);
            Console.WriteLine($"Count {arrayList.Count} Capacity {arrayList.Capacity}");//3 4

            /*
        3.LinkedList
       linked list, therefore, each node points forward to the Next node and backward to the Previous node. It is a dynamic collection which grows, according to the need of your program. 
       Time Complexity of Accessing (Getting/Setting) an element in Linked List: O(n) Typically O(n),
       Business Case : when you need to perform frequent insertion or deletion operations at any position, and do not care about random access, sorting, or searching
*/
            LinkedList<string> names = new LinkedList<string>();
            names.AddLast("Heba");
            names.AddLast("Mai");
            names.AddLast("Aliaa");
            names.AddLast("Hala");
            names.AddFirst("Samar");//added to first index  

            // Iterate list element using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            /*
            3.Stack<T>
            stack is a special type of collection that stores elements in LIFO style (Last In First Out).
            Time Complexity: The searching operation also takes a total time of O(N), as reaching any specific element isn't possible without popping the elements stored before it. Operations like insertion or deletion in a stack take constant time i.e. O(1).
            Business Case :Stack is useful to store temporary data in LIFO style, and you might want to delete an element after retrieving its value.
*/
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            foreach (var item in myStack)
                Console.Write(item + ","); //prints 4,3,2,1, 

            /*
            3.Queue<T>
           Queue is a linear data structure that follows FIFO approach (First In First Out). 
            Time Complexity:To find an element in a queue with a LinkedList the time complexity is O(n) because it's necessary to traverse all elements for the worst-case scenario. To delete or insert an element in the middle of the queue the time complexity is also O(n).
            Business Case :when things don't have to be processed immediately, but have to be processed in First In First Out order
            */
            Queue<int> callerIds = new Queue<int>();
            callerIds.Enqueue(1);
            callerIds.Enqueue(2);
            callerIds.Enqueue(3);
            callerIds.Enqueue(4);

            foreach (var id in callerIds)
                Console.Write(id); //prints 1234
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
            //List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            //List<int> evenNumbers = new List<int>();
            //for (int i = 0; i < list.Count; i++) 
            //{
            //    if (list[i]%2==0)
            //    {
            //        evenNumbers.Add(list[i]);
            //    }
            //}

            #endregion

            #region Q3
            //FixedSizeList<int> numbers = new FixedSizeList<int>(3);
            //Console.WriteLine(numbers.values.Length);
            //numbers[1] = 5;

            //Console.WriteLine(numbers.Count);
            //Console.WriteLine(numbers[1]);
            //numbers.Add(1);
            //numbers.Add(1);
            //numbers.Add(2); 
            //numbers.Add(3);

            //foreach (int i in numbers.values) 
            //Console.WriteLine(i);


            #endregion

            #endregion



        }
    }
}
