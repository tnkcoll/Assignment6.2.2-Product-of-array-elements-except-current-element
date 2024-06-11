namespace Assignment6._2._2_Product_of_array_elements_except_current_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            int[] result = GetSumOfArrayValuesExceptCurrntValue(nums);

            foreach (int i in result)
            {
                Console.Write($"{i} ");
            }

        }

        static int[] GetSumOfArrayValuesExceptCurrntValue(int[] nums)
        {
            int[] result = new int[nums.Length];
            result[0] = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                result[i] = result[i - 1] * nums[i - 1];
            }

            int right = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                result[i] = result[i] * right;
                right = right * nums[i];
            }
            return result;
        }
    }
}
