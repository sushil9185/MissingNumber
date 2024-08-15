namespace MissingNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2,3, 5, 6};
            int n = 6;
            Console.WriteLine(FindMissingNumber4(myArray, n));
        }

        static int FindMissingNumber4(int[] a, int n)
        {
            int xor1 =0, xor2 =0;
            for(int i = 0; i < a.Length; i++)
            {
                xor1 =xor1 ^ a[i];
                xor2 =xor2 ^ (i + 1);
            }
            xor2 = xor2 ^ n;

            return xor1 ^ xor2;

        }
        static int FindMissingNumber3(int[] a, int n)
        {
            int arraySum = 0;

            for(int i = 0; i< a.Length; i++)
            {
                arraySum += a[i];
            }

            int totalSum = n * (n + 1) / 2;

            return totalSum - arraySum;

        }

        static int FindMissingNumber2(int[] a, int n)
        {
            Dictionary<int, bool> dict = new Dictionary<int, bool>();
            for(int i = 0; i < a.Length;i++)
            {
                dict[a[i]] = true;
            }

            for(int i =1; i<=n; i++)
            {
                if (!dict.ContainsKey(i))
                    return i;
            }


            return -1;
        }

        static int FindMissingNumber1(int[] a, int n)
        {
            for(int i = 1; i <= n; i++)
            {
                int flag = 0;
                for(int j = 0; j < a.Length; j++)
                {
                    if (a[j] == i)
                    {
                        flag = 1;
                        break;
                    }
                }

                if(flag == 0)
                    return i;
            }

            return -1;
        }
    }
}