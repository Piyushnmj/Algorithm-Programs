namespace AlgorithmPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs");

            Console.WriteLine("Select Search and Sort Method from Below: ");
            Console.WriteLine("1. Binary Search \n2. Insertion Sort \n3. Bubble Sort \n4. Merge Sort");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:

                    BinarySearchWord<string> obj = new BinarySearchWord<string>();
                    obj.WordExistsOrNot<string>();
                    Console.ReadLine();
                    break;

                case 2:

                    string[] names = { "OOPS", "Array", "Dictionary", "Generics", "Delegates", "LinkedList", "Stack", "Queue", "HashTable", "Events", "Regular Expressions" };
                    InsertionSortMethod<string> objInsertion = new InsertionSortMethod<string>();

                    Console.WriteLine("\nBefore sorting array elements are: ");
                    objInsertion.Display<string>(names);

                    objInsertion.Sort<string>(names);
                    Console.WriteLine("\n\nAfter sorting array elements are: ");
                    objInsertion.Display<string>(names);
                    Console.ReadLine();
                    break;

                case 3:

                    int[] array = { 51, 12, 49, 26, 85, 153, 4 };
                    BubbleSortMethod<int> objBubbleSort = new BubbleSortMethod<int>();

                    Console.WriteLine("\nBefore sorting array elements are: ");
                    objBubbleSort.Display<int>(array);

                    objBubbleSort.Sort<int>(array);
                    Console.WriteLine("\n\nAfter sorting array elements are: ");
                    objBubbleSort.Display<int>(array);

                    Console.ReadLine();
                    break;

                case 4:

                    int[] numArray = { 51, 12, 49, 26, 85, 153, 4 };
                    MergeSortMethod<int> objSort = new MergeSortMethod<int>();

                    Console.WriteLine("\nBefore sorting array elements are: ");
                    objSort.Display<int>(numArray);

                    objSort.Sort<int>(numArray, 0, numArray.Length - 1);
                    Console.WriteLine("\n\nAfter sorting array elements are: ");
                    objSort.Display<int>(numArray);

                    Console.ReadLine();
                    break;
            }

        }
    }
}