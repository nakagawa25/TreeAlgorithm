using System.Collections.Generic;
using System.Linq;

namespace TestDev_Paradigma.Tools
{
    public static class ValidationTools
    {
        public static bool ValidateArrayDuplicity(List<int> inputArray)
        {
            var distinctArray = inputArray.Distinct().ToList();
            return distinctArray.Count == inputArray.Count ? true : false;
        }

        public static bool VerifyDuplicityInArray(List<int> array, int inputValue)
        {
            foreach (int arrayItem in array)
            {
                if (arrayItem == inputValue)
                    return false;
            }
            return true;
        }
    }
}
