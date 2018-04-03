using System;

namespace basic_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        //Basic 13
        public static void PrntInt()
        {
            for(int i=0; i<256; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrntOdd()
        {
            for(int i=0; i<256; i++)
            {
                if(i%2==1)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void PrntSum()
        {
            int sum = 0;
            for(int i=0; i<256; i++)
            {
                sum += i;
                Console.WriteLine("New Number: {0} Sum: {1}", i, sum);
            }
        }

        public static void ItArr(int[] arr)
        {
            for(int idx=0; idx<arr.Length; idx++)
            {
                Console.WriteLine(arr[idx]);
            }
        }

        public static void MaxArr(int[] arr)
        {
            int max = arr[0];
            for(int idx=0; idx<arr.Length; idx++)
            {
                if(arr[idx] > max)
                {
                    max = arr[idx];
                }
            }
            Console.WriteLine(max);
        }

        public static void AvgArr(int[] arr)
        {
            int avg = 0;
            for(int idx=0; idx<arr.Length; idx++)
            {
                avg += arr[idx];
            }
            avg = avg/arr.Length;
            Console.WriteLine(avg);
        }

        public static void ArrOdd()
        {
            int[] returnArr = new int[(256/2)];
            int counter = 0;
            for(int i=0; i<256; i++)
            {
                if(i%2==1)
                {
                    returnArr[counter] = i;                 
                    counter++;
                }
            }
        }

        public static int GTY(int[] arr, int y)
        {
            int count = 0;
            for(int idx=0; idx<arr.Length; idx++)
            {
                if(arr[idx] > y)
                {
                    count++;
                }
            }
            return count;
        }

        public static int[] SquareArr(int[] arr)
        {
            for(int idx=0; idx<arr.Length; idx++)
            {
                arr[idx] = arr[idx]*arr[idx];
            }
            return arr;
        }

        public static int[] NoNegArr(int[] arr)
        {
            for(int idx=0; idx<arr.Length; idx++)
            {
                if(arr[idx]<0)
                {
                    arr[idx] = 0;
                }
            }
            return arr;
        }

        public static Tuple<int, int, float> MinMaxAvg(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            float avg = arr[0];
            for(int idx=1; idx<arr.Length; idx++)
            {
                if(arr[idx] > max)
                {
                    max = arr[idx];
                }
                if(arr[idx] < min)
                {
                    min = arr[idx];
                }
                avg += arr[idx];
            }
            avg = avg/arr.Length;
            return new Tuple<int, int, float>(min, max, avg);
        }

        public static int[] ShiftArr(int[] arr)
        {
            for(int idx=0; idx<arr.Length-1; idx++)
            {
                arr[idx] = arr[idx+1];
            }
            arr[arr.Length-1] = 0;
            return arr;
        }

        public static object[] NumToStr(int[] arr)
        {
            object[] objArr = new object[arr.Length];
            for(int idx=0; idx<arr.Length; idx++)
            {
                if(arr[idx] < 0)
                {
                    objArr[idx] = "Dojo";
                }
                else
                {
                    objArr[idx] = arr[idx];
                }
            }
            return objArr;
        }

    }
}

