using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ListPractice
{
    public class Class1
    {

        public void List(List<int> list)                   //Adding the elements of list
        {
            int sum = 0;
            foreach (var element in list)
            {
                sum += element;
            }
            Console.WriteLine(sum);
        }


    }

    public class Class2                                        //Remove Duplicates From a List
    {
        public void List(List<int> list)
        {
            List<int> uniqueList = new List<int>();
            foreach (var element in list)
            {
                if (!uniqueList.Contains(element))
                {
                    uniqueList.Add(element);
                }
            }
            foreach (var element in uniqueList)
            {
                Console.WriteLine(element);
            }

        }
    }

    public class Class3                                           //Check if a list is sorted in ascending order
    {
        public void List(List<int> list)
        {
            bool isSorted = true;
            for (int i = 0; i < (list.Count - 1); i++)
            {
                if (list[i] > list[i + 1])
                {
                    isSorted = false;
                    break;
                }
            }
            Console.WriteLine(isSorted);
        }
    }


    public class Class4
    {
        public void List(List<int> list)                                //Reverse a given list:
        {
            for (int i = 0, j = list.Count - 1; i < j; i++, j--)
            {
                int temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }

    public class Class5                                // Merge two lists into a single sorted list
    {
        public void List(List<int> list1, List<int> list2)
        {
            List<int> mergedList = new List<int>(list1);
            foreach (var element in list2)
            {
                int index = 0;
                while (index < mergedList.Count && element > mergedList[index])
                {
                    index++;
                }
                mergedList.Insert(index, element);
            }

            foreach (var element in mergedList)
            {
                Console.WriteLine(element);
            }

        }
    }

    public class Class6
    {
        public void List(List<int> list)    //List Rotation
        {
            int positionsToRotate = 3;
            for (int i = 0; i < positionsToRotate; i++)
            {
                int lastElement = list[list.Count - 1];
                for (int j = list.Count - 1; j > 0; j--)
                {
                    list[j] = list[j - 1];
                }
                list[0] = lastElement;
            }

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }

        }
    }

    public class Class7                 //count occurenece
    {
        public void List(List<int> list)
        {
            Dictionary<int, int> occurrences = new Dictionary<int, int>();
            foreach (var element in list)
            {
                if (occurrences.ContainsKey(element))
                {
                    occurrences[element]++;
                }
                else
                {
                    occurrences[element] = 1;
                }
            }

        }
    }

    public class Class8
    {
        public void Zeros(List<int> L1)
        {
            List<int> newList = new List<int>(L1.Count);
            int k = 0;

            
            for (int i = 0; i < L1.Count; i++)
            {
                if (L1[i] != 0)
                {
                    newList.Add(L1[i]);
                    k++;
                }
            }

           
            for (int i = k; i < L1.Count; i++)
            {
                newList.Add(0);
            }

            
            for (int z = 0; z < newList.Count; z++)
            {
                Console.WriteLine(newList[z]);
            }
        }
    }


    public class Class9()                       //Yet to be done correctly
    {
        public void Rotate(List<int> L1)
        {
            List<int> newList = new List<int>();
            int k = 0;

            int Position = 3;

            for (int i = L1.Count - 1; i > L1.Count - 3; i--)
            {
                newList[k] = L1[i];
                k++;

            }


            for (int j = 0; j < L1.Count - 3; j++)
            {
                newList[k] = L1[j];

            }


            for (int z = 0; z < newList.Count; z++)
            {
                Console.WriteLine(newList[z]);
            }
        }



    }

    public class class10()
    {
       
            
            public string ReverseWords(string input)
            {
                
                string[] words = input.Split(' ');

               
                Array.Reverse(words);

                
                string reversedString = string.Join(' ', words);

                return reversedString;
            }
        



    }
}



    


