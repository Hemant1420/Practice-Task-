using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionarypractice
{
    public class Maintest
    {
        static void Main()
        {
            List<string> list = ["Rahul", "Rohan", "Sahil"];
            Dictionary<string, int> dict1 = new Dictionary<string, int>();
            {
                dict1["Rahul"] = 2;
                dict1["Alice"] = 3;
                dict1["Amey"] = 4;
                dict1["Rohit"] = 5;
            }

            Dictionary<string, int> dict2 = new Dictionary<string, int>();
            {
                dict2["Rahul"] = 6;
                dict2["Rohit"] = 7;
                dict2["Bob"] = 8;
                dict2["Nobi"] = 9;
            }

            Dictionary<char, int> dict3 = new Dictionary<char, int>();
            {
                dict3['a'] = 6;
                dict3['b'] = 7;
                dict3['c'] = 8;
                dict3['d'] = 9;
            }



            Class1 user = new Class1();
            user.Dict(list);
            
            Class2 user2 = new Class2();
            user2.dict(dict1,dict3);

            Class3 user3 = new Class3();    
            user3.dict(dict1 ,dict2);

        }





    }
}
