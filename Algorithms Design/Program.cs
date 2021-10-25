using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Algorithms_Design
{
    class FileWork
    {



        public int fileInput()
        {
            FileInfo numberFile = new FileInfo("NumberList.txt");
            FileInfo nums = new FileInfo("17.txt");

            string[] numberArray = new string[] { };

            var lenghtOfFile = 0;

            //loops through the file using StreamReader
            using (StreamReader sr = nums.OpenText())
            {
                string s = null;
                
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);

                    lenghtOfFile += 1;
                                   
                }//end while
                
                sr.Close();
                Console.WriteLine("The length of this file is: " + lenghtOfFile);
            }//end using


            return lenghtOfFile;
        }//end fileInput function
  
       
    }

    class QuickSort
    {
        private int Partition(int[] numArray, int low, int high)
        {



            int lowP = low;
            int highP = high;
            int[] ary = numArray;
            int pivot = ary[highP];

            //index of smaller element
            int i = lowP - 1;
            
            for (int j = lowP; j <= highP; j++)
            {
                //if the current element is smaller than or equal to pivot do this:
                if (ary[j] <= pivot)
                {
                    //increases the index of the smaller element
                    i++;

                }

                    int temp1 = ary[i + 1];
                    ary[i + 1] = ary[highP];
                    ary[highP] = temp1;

                Console.WriteLine();
            }

         

            

            return 0;
        }

        public void Sort()
        {

            int[] numbArray = new int[] { 5, 4, 7, 3, 1, 2, 6 };

            int lowPivot;
            int highPivot;

            //takes the first and last element of the array and assigns them to the low and high pivot.
            highPivot = numbArray.Last();
            lowPivot = numbArray.First();


            Console.WriteLine();
            
           // Console.WriteLine("the low pivot is: " + lowPivot);
           // Console.WriteLine("the high pivot is: " + highPivot);


            int pivotIndex = numbArray.Length / 2;

            //Console.WriteLine("The Pivot Index is: " + pivotIndex);

           Partition(numbArray, lowPivot, highPivot);

        }



    }

    class Program
    {


        static void Main(string[] args)
        {

            FileWork running = new FileWork();
            QuickSort qs = new QuickSort();



            running.fileInput();
            qs.Sort();

            Console.ReadKey();
        }
    }
}
