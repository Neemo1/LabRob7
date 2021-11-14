using System;

namespace LabRob7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k=0;
            string strValue;
            int[] iArray2 = new int[30];
            int[,] iArray = new int[5, 6];
            Console.WriteLine(" Заполните масив числами");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 6; j++) 
                {
                    strValue = Console.ReadLine();
                    iArray[i, j] = Convert.ToInt32(strValue);             
                }            
            }
            Console.WriteLine("\n******* Двомірний масив B[5,6]****Одномірний масив [30]");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 6; j++)
                {

                   Console.WriteLine("\niArray [" + i + "," + j + "] =" + iArray[i, j]);
                   iArray2[k] = iArray[i, j];
                   k++;
                }
            }
            Console.WriteLine("\n****Одномірний масив [30]**************");
            for (k = 0; k < 30; k++) {

                Console.WriteLine("\niArray2 [" + k + "] = " + iArray2[k]);

            }
            Console.WriteLine();
        }
    }
}
