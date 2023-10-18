using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


/*
 //Task_2
 palindrome
Напишите метод, который проверяет является ли 
переданное число «палиндромом». Число передаётся в 
качестве параметра. Если число палиндром нужно вернуть из метода true, иначе false.
Палиндром — число, которое читается одинаково как 
справа налево, так и слева направо. Например:
1221 — палиндром;
3443 — палиндром;
7854 — не палиндром
 */
namespace DZ_3_C_Sharp_Multiplication__matrix_Structural__Features
{
    internal class Palindrom
    {
        public static bool isPalindrom = IsPalindrom(Program.num);               
        public static bool IsPalindrom(int num)
        {
            string numString = num.ToString();
            int length = numString.Length;
            for(int i = 0; i < length/2; i++)
            {
                if (numString[i] != numString[length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
       
    }
}
