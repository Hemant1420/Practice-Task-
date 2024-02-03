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
        List<int> list1 = [ 2, 1, 4, 3, 5, 6, 7, 6, 9, 0];
        List<int> list2 = [11,3,234,54,64,24,98,67,98];
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
        Class6 user6 = new Class6();
        user6.List(list1);
        Class7 user7 = new Class7();
        user7.List(list1);



        }

    }
}
