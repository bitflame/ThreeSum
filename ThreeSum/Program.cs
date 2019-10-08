using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSum
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        private static IList<IList<Int32>> ThreeSum (Int32 [] nums)
        {
            List<IList<Int32>> results = new List<IList<int>>();
            if (nums==null || nums.Length == 0)
            {
                return results;
            }
            Array.Sort(nums);
            for (int i = 0; i < nums.Length-2; i++)
            {
                //check for duplicates 
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                int target = -nums[i];
                int left = i + 1;
                int right = nums.Length - 1;
                TwoSumHelper(nums, results, target, left, right);
            }
            return results;
        }
        private static void TwoSumHelper (Int32 [] nums, List<IList<Int32>> results, Int32 target, 
            Int32 left, Int32 right)
        {
            while (left < right)
            {
                if (nums[left] + nums[right] == target)
                {
                    results.Add(new Int32[] { -target, nums[left], nums[right] });
                    left++;
                    right--;
                    while (left < right && nums[left] == nums[left - 1])
                    {
                        left++;
                    }
                    while (left < right && nums[right] == nums[right + 1])
                    {
                        right--;
                    }
                }
                else if (nums[left] + nums[right] > target)
                {
                    right--;
                }
                else if (nums[left] + nums[right] < target)
                {
                    left++;
                }
            }
        }
    }
}
