using System.Collections;

namespace Arrays101LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArraySolution insertValues = new ArraySolution();
            
            insertValues.insertValuesIntoArray(4, 1, 3);

            Console.ReadLine(); 
    

        }

        public static void printArray(int[] intArray)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine("Index " + i + " contains " + intArray[i]);
                
            }
        }
    }
}