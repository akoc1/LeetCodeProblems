using System;
using System.Linq;

namespace Median_of_Two_Sorted_Arrays
{
    internal class Program
    {
        private double FindMedianSortedArrays(int[] nums1, int[] nums2){
            int[] mergedArray = nums1.Concat(nums2).ToArray();
            int index;
            double median = 0D;
            
            Array.Sort(mergedArray);

            if (mergedArray.Length % 2 == 0){
                index = mergedArray.Length / 2 - 1;
                median = (mergedArray[index] + mergedArray[index + 1]) / 2D;
            }
            else{
                index = (mergedArray.Length - 1) / 2;
                median = mergedArray[index];
            }
            
            return median;
        }
        
        public static void Main(string[] args){
            Program program = new Program();

            Console.WriteLine(program.FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3, 5, 4 })); // 3
        }
    }
}