using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pigeonhole_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Taking the size of an array from user
            Console.WriteLine("Enter the size of an array for sorting : ");
            int n = Convert.ToInt32(Console.ReadLine());
            //initialize the array with n size
            int[] array = new int[n];  
            
            Console.WriteLine("Enter the Element to be sorted : ");
            // input array element from user
            for (int i =0;i<n;i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Sorted order by pigeon hole is : ");
            Phole ph = new Phole();  //object of the class
            //calling the function
            ph.pigeonhole_sort(array, array.Length);

            //printing the sorting array
            for (int i = 0; i < array.Length; i++)
           
            {
                Console.WriteLine("");
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
    }
  public class Phole
    {

        public void pigeonhole_sort(int[] arr,int n)
        {
            int minimum = arr[0];   
           int maximum = arr[0];
          int range, i, j, index;
            // Find minimum and maximum values in array.
            for (int a = 0; a < n; a++)  
            {
                if (arr[a] > maximum)     
                    maximum = arr[a];         
                if (arr[a] < minimum)    
                    minimum = arr[a];    
            }

            range = maximum - minimum + 1;   //computing range 
            //array of pigeonhole
            int[] phole = new int[range];    

            for (i = 0; i < n; i++)          
                phole[i] = 0;
            //populate the pigeonhole
            for (i = 0; i < n; i++)          
                phole[arr[i] - minimum]++;

            //put the elements back into the array in order 
            index = 0;

            for (j = 0; j < range; j++)
                while (phole[j]-- > 0)
                    arr[index++] = j + minimum;

        }

    }
}
