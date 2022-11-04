namespace HelloWorld
{
    class MyBigNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Số thứ 1: ");
            string num1 = Console.ReadLine();
            Console.WriteLine("Số thứ 2: ");
            string num2 = Console.ReadLine();
            Sum(num1,num2);
        }
        static string Sum(string num1, string num2)
        {
            int maxLength = 0;
            if (num1.Length > num2.Length)
            {
                maxLength = num1.Length;
            }
            else
            {
                maxLength = num2.Length;
            }
            int[] ResultArray = new int[maxLength];
            int[] NumArray1 = getNumArray(num1,maxLength);
            int[] NumArray2 = getNumArray(num2,maxLength);
            int plus = 0;
            int result = 0;
            int step = 1;
            for (int i = maxLength - 1; i > -1; i--)
            {
                result = NumArray1[i] + NumArray2[i] + plus;
                ResultArray[i] = result % 10;
                plus = result / 10;
                Console.WriteLine(string.Format("Bước {0}  : {1} + {2} = {3} nhớ {4} ", step, NumArray1[i], NumArray2[i], result, plus));
                step++;
            }
            Console.WriteLine(string.Format("Result  : {0}", string.Join(string.Empty, ResultArray)));
            return null;
        }
        static int[] getNumArray(string pNumArray, int maxLength)
        {
            int[] NumArray = new int[maxLength];
            for (int i = 0; i < pNumArray.Length; i++)
            {
                NumArray[maxLength - pNumArray.Length + i] = int.Parse(pNumArray[i].ToString());
            }
            return NumArray;
        }
    }
}