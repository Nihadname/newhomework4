// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading.Channels;

Console.WriteLine("Hello, World!");
#region 1ci
//1) Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.
int num1 = 42;
bool NumberDivision(int num)
{
    return num%21==0 ? true : false;
}
Console.WriteLine(NumberDivision(num1));
#endregion
#region 2ci
//2) n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
string SumOfThem(int num,int num1)
{
   
    if (num % 2 == 0 && num1 % 2 == 0)
    {
        int result = num + num1;
        return ($"bu ededin cemi {result} ");
    }
    return "cut deyil";
}
Console.WriteLine(SumOfThem(n, m));
#endregion
#region 3cu
//1.Verilmiş n və m (n<m) ədədləri arasında neçə tək ədəd olduğunu tapın.
int num01 = 7;
int num2 = 36;
int icreasment = default(int);

string OddFounder(int num,int num1, int icreasment1)
{
    for(int i = num; i < num1; i++)
    {
        if (num < num1)
        {
            if(i % 2 == 1)
            {
                icreasment1++;
            
            }

                    
        }
    }
    return ($"arasindaki reqem sayi {icreasment1}");
}
Console.WriteLine(OddFounder(num01, num2, icreasment));
#endregion
#region 4cu
string SumOfOdd(int num1,int num2,int icreasment)
{
    for(int i = num1; i < num2; i++)
    {
        if (num1 < num2)
        {
            if (i % 2 == 1)
            {
                icreasment += i;

            }


        }
    }
    return ($"ededlerin cemi{icreasment}");
}
Console.WriteLine(SumOfOdd(num01,num2, icreasment));
#endregion