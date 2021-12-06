using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp.ArrayOperations
{
    class _384_ShuffleArray
    {
        int[] array;
        int[] original;

        public _384_ShuffleArray(int[] nums)
        {
            array = nums;
            original = (int[])nums.Clone();
        }

        public int[] Reset()
        {
            array = original;
            original = (int[])original.Clone();

            return array;
        }

        public int[] Shuffle()
        {
            var aux = array.ToList();

            for (var i = 0; i < array.Count(); i++)
            {
                var rand = new Random();
                var removeIndex = rand.Next(aux.Count());
                array[i] = aux[removeIndex];
                aux.RemoveAt(removeIndex);
            }

            return array;
        }
    }
}
