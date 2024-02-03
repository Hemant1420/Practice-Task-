using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Arraypractice
{
   public class Class1
    { 
        public void sum(int[] arr, int a)  //Determine if any two integer in array sum to given integer
        {
            int num = a;

            foreach (int i in arr)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else if (num == i + j)
                    {
                        Console.Write(i + ",");
                        Console.WriteLine(j);
                    }

                }
            }

        }

    }

    public class class2
    {

        public void listsort(int[] arr)  //Sort Array in Descending order
        {
            
           Array.Sort(arr);
           Array.Reverse(arr);
            foreach(int i in arr)
            {
                Console.Write(i + ", ");
            }
            
        }
    }


    public class class3
    {

        public void listsort(int[] arr)  //Maximum element in array
        {

            Dictionary<int, int> newDict = new Dictionary<int, int>();

            for(int i=0; i< arr.Length; i++)
            {
                if (newDict.ContainsKey(arr[i]))
                {
                    newDict[arr[i]] = newDict[arr[i]] + 1;
                }
                else
                {
                    newDict.Add(arr[i], 1);
                    
                }

            }

            int max = newDict.Values.Max();

            foreach (var pair in newDict)
            {
               
                if( pair.Value == max)
                {
                    Console.WriteLine(pair.Key + ", ");
                }

            }




        }
    }

    public class class4
    {
        public void listsort(int[] arr1, int[] arr2)  //Sort Array in Descending order
        {

            Array.Sort(arr1);
            Array.Sort(arr2);
            int[] mergedArray = arr1.Concat(arr2).ToArray();

            foreach (int i in mergedArray)
            {
                Console.Write(i + ", ");
            }



        }
    }

     public class class5
     {
         public void sum()
         {
             int[] arr = Array.Empty<int>();

             int i;
             for (i = 0; i < 101; i++)
             {
                 if (i == 4 || i == 8)
                 {
                     continue;
                 }
                 else
                 {
                     arr = arr.Append(i).ToArray();
                     Console.WriteLine(i);
                 }





             }







             for(int k=0; k<=arr.Length; k++)
             {
                 if (arr[k]+1 == arr[k + 1])
                 {
                     continue;

                 }
                 else
                 {
                     Console.WriteLine(arr[k]+1);
                 }
             }

         }

     }  


    public class class6
    {
        public void minmax(int[] arr)  //Swapping the min max in array
        {
            int max = arr[0];
            int min = arr[1];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine(max);

            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] < min)
                {
                    min = arr[j];
                }
            }
            Console.WriteLine(min);


            int indexMax = Array.IndexOf(arr, max);
            int indexMin = Array.IndexOf(arr, min);

            arr[indexMin] = max;
            arr[indexMax] = min;

            foreach (int i in arr)
            {
                Console.WriteLine(i + " ");
            }

        }






    }


    public class class7()
    {
        public void zero(int[] arr)
        {

            int[] empty = Array.Empty<int>(); // Create an empty array using Array.Empty<T>()


            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    empty = empty.Append(arr[i]).ToArray();



                }



            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {

                    empty = empty.Append(arr[i]).ToArray();


                }



            }
            for (int j = 0; j < empty.Length; j++)
            {
                Console.WriteLine(empty[j]);
                arr.Append(empty[j]).ToArray();

            }


        }
    }

    public class class9()
    {
        public void listsort(int[] arr)  //Maximum element in array
        {

            int[] empty = Array.Empty<int>(); // Create an empty array using Array.Empty<T>()
            int[] duplicate = Array.Empty<int>(); // Create an empty array using Array.Empty<T>()

            
            for (int i = 0; i < arr.Length; i++)
            {

                int array = Array.IndexOf(empty, arr[i]);  //checking if the element exist in empty array
                int array2 = Array.IndexOf(duplicate, arr[i]);   //checking if the repeated element is alreday present in duplicate array so that we don't print the repeated element two times

                if (array == -1)
                {
                    empty = empty.Append(arr[i]).ToArray();
                }
                else
                {
                    if (array2 == -1)
                    {
                        duplicate = duplicate.Append(arr[i]).ToArray();
                    }
                }

            }
            for (int j = 0; j < duplicate.Length; j++)
            {
                Console.WriteLine(duplicate[j]);

            }


        }
    }
}














