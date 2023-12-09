namespace arrayTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 2, 9, -4, 6, 1, -6, 7, -8, 5, -9};

            //int nums = IndexOfMin(array, 0, array.Length-1);
            //System.Console.WriteLine(nums);

            //PrintArray(array);
            //SortArray(array);
            //PrintArray(array);

            //calcolo fattoriale
            //4! = 4 * 3 * 2 * 1 = 24

            Console.WriteLine(FactRec(5));
            Console.WriteLine(FactIter(5));
            Console.WriteLine(FibRec(5));
            Console.WriteLine(FibIter(5));
        }

        static int IndexOfMin(int[] array, int from, int to) 
        {   
            int indexOfMin = from;
            for (int i = from+1; i <= to; i++)
            {
                
                if (array[i] < array[indexOfMin])
                {
                    indexOfMin = i;
                }
            }
            
            return indexOfMin; 
        }

        static void Swap(int[] array, int j, int i)
        {
            int temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }

        static void SortArray(int[] array)
        {
            for(int i = 0; i < array.Length-1; i++)
            {
                int temp = IndexOfMin(array, i, array.Length-1);
                Swap(array, i, temp);
            }
        }

        static void PrintArray(int[] array)
        {
            foreach(int i in array)
            {
                System.Console.WriteLine($"{i}, ");
            }
        }

        static int FactRec(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }

            return num * FactRec(num - 1);
        }

        static int FactIter(int num)
        {
            int product = 1;

            for (int i = 1; i <= num; i++)
            {
                product *= i;
            }

            return product;
        }

        public static int FibRec(int num)
        {
            if((num == 0) || (num == 1))
            {
                return num;
            }

            return FibRec(num - 1) + FibRec(num - 2);
        }

        public static int FibIter(int num)
        {
            if ((num == 0) || (num == 1))
            {
                return num;
            }

            int a = 0;
            int b = 1;

            for (int i = 0; i < num; i++)
            {
                var temp = a + b;
                a = b;
                b = temp;
            }

            return a;
        }
    }
}
