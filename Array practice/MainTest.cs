using Arraypractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_practice
{
    internal class MainTest
    {
        static void Main()
        {
            int[] arr = { 1,0,7,0,3,0,6,6,3,9,2,3,1,3,6,5,6,7,8,5,4,2,4,5,6};
            int[] arr2 = { 75,76,4,7,57,32,54,76,9};
            Class1 U1 = new Class1();
            U1.sum(arr,6);
            class2 U2 = new class2();
            U2.listsort(arr);
            class3 U3 = new class3();
            U3.listsort(arr); 
            class4 U4 = new class4();
            U4.listsort(arr,arr2);
            class6 U6 = new class6();
            U6.minmax(arr);
            class7 U7 = new class7();
            U7.zero(arr);
            class9 U9 = new class9();
            U9.listsort(arr);
        }

    }

}
