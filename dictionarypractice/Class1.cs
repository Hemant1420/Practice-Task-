using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionarypractice
{
    public class Class1
    {
        public void Dict(List<string> list)                         //occurence of each word in a list of strings using dictionary
        {
            Dictionary<char,int> dict = new Dictionary<char,int>();
            for (int i = 0; i < list.Count; i++) 
            {
                for(int j = 0; j < list[i].Length; j++)
                {
                    if (dict.ContainsKey(list[i][j]))
                    {
                        dict[list[i][j]]++;
                    }
                    else
                    {
                        dict[list[i][j]] = 1;
                    }
                }
               

            }
            foreach (var c in dict)
            {
                char key = c.Key;
                int value = c.Value;
                Console.WriteLine(key + " : " + value);

            }



        }
    }


    public class Class2()                           //Merging two dictionary
    {
        public void dict(Dictionary<string, int> dict1, Dictionary<char, int>dict2)
        {
            foreach(var c in dict2)
            {
                string key = Convert.ToString(c.Key);
                int value = c.Value;
                dict1[key] = value;

            }

            foreach(var c in dict1)
            {
                string key1 = c.Key;
                int value1 = c.Value;
                Console.WriteLine(key1 + " : " + value1);   
            }
        }
    }

    public class Class3
    {
        public void dict(Dictionary<string, int> dict1, Dictionary<string, int> dict2)
        {
            foreach( var c in dict1)
            {
                if (dict2.ContainsKey(c.Key))
                {
                    string Key = c.Key;
                    int value = c.Value;
                    string key2 = c.Key;
                    int value2 = dict2[c.Key];

                    Console.WriteLine($" {Key} : {value}, {key2} : {value2}");




                }
            }

        }
    }
}





