namespace Assignment6._2._2_Product_of_array_elements_except_current_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 1, 0, -3, 3 };
            int[] result = GetSumOfArrayValuesExceptCurrntValue(nums);

            foreach (int i in result)
            {
                Console.Write($"{i} ");
            }

        }

        static int[] GetSumOfArrayValuesExceptCurrntValue(int[] nums)
        {
            int[] result = new int[nums.Length];
            int product;

            for (int i = 0; i < nums.Length; i++)
            {
                product = 1;
                for(int j = 0; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        product = product * nums[j];
                    }
                }
                result[i] = product;
            }
            return result;
        }
    }
}
