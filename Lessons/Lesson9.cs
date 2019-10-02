using System;

/* This class will go over lesson 9 content Lesson 9 - Arrays */
namespace CSharpClass.Lessons
{
    public class Lesson9
    {

        // This method will show different ways to create a single dimension array.
        public void ArrayDeclarations()
        {
            int[] myIntArray = new int[3];
            int[] myOtherArray = { 1, 3, 5 };
            int[] myThirdArray = new int[] { 1, 5, 10 };
        }   // end method array declaration

        // Basic array with a for loop
        public void BasicArray()
        {
            int[] intArray = { 2, 5, 34, 56, 28, 32 };
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            } // end for loop
        } // end method basic array

        // Two-dimensional array with 2 for loops
        public void MutliArraySample()
        {
            int[,] sampleIntArray = new int[2, 2];
            sampleIntArray[0, 0] = 2;
            sampleIntArray[0, 1] = 4;
            sampleIntArray[1, 0] = 6;
            sampleIntArray[1, 1] = 8;

            for (int i = 0; i < sampleIntArray.GetLength(0); i++)
            {
                for (int k = 0; k < sampleIntArray.GetLength(i); k++)
                {
                    Console.WriteLine(sampleIntArray[i, k]);
                } // end inner for loop
            } // end outer for loop

        } // end method multi array sample

        // This method will demonstrate a 3D array
        public void My3DArrayExample()
        {
            int[,,] my3Darray = new int[2, 2, 3]
            {{{1,2,3},{4,5,6}} , {{7,8,9},{10,11,12}}};

            for (int i = 0; i < my3Darray.GetLength(0); i++)
            {
                for (int k = 0; k < my3Darray.GetLength(1); k++)
                {
                    for (int m = 0; m < my3Darray.GetLength(2); m++)
                    {
                        Console.WriteLine(my3Darray[i, k, m]);
                    } // end inner inner for loop
                } // end inner for loop
            } // end outer for loop
        } // end method my 3d array example

        // A basic jagged array with 2 loops
        public void MyJaggedArrayExample()
        {
            int[][] sampleArray = new int[3][];
            sampleArray[0] = new int[]{ 2, 4 };
            sampleArray[1] = new int[] { 6, 8, 10 };
            sampleArray[2] = new int[] { 12, 14, 16, 18, 20 };

            for(int i = 0; i < sampleArray.Length; i++)
            {
                Console.Write("Row({0})",i);
                for(int k = 0; k < sampleArray[i].Length; k++)
                {
                    Console.Write("{0},", sampleArray[i][k]);
                } // end inner for loop
                Console.WriteLine();
            } // end outer for loop
        } // end method my jagged array example




    } // end class
} // end namespace