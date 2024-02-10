using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPractice
{
    public class MainList
    {
        static void Main() {
        List<int> list1 = [0,0, 2, 1, 4, 3, 5, 6, 7, 6, 9, 0,0];
        List<int> list2 = [11,3,234,54,64,24,98,67,98];
            int[] arr = { 0, 0, 8, 6, 5, 6, 0, 0 };

        Class1 user1 = new Class1();
        user1.List(list1);
        Class2 user2 = new Class2();
        user2.List(list1);
        Class3 user3 = new Class3();
        user3.List(list1);
        Class4 user4 = new Class4();
        user4.List(list1);
        Class5 user5 = new Class5();
        user5.List(list1,list2);
        //Class9 user9 = new Class9();
        //user9.Rotate(list1);
        Class7 user7 = new Class7();
        user7.List(list1);
        Class8 user8 = new Class8();
        user8.Zeros(list1);



        }

    }
}
