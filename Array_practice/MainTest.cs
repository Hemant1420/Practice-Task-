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
            int[] arr = { 1,2,3,4,5};
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
             class10 U10 = new class10();
             U10.Duplicate(arr);

            
            class12 U12 = new class12();
            U12.Sumcount(arr, 4);
            
        }

    }

}
