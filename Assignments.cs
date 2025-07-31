using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Assignments
    {
        internal void Sum()
        {
            Console.WriteLine(10+20);
            Console.WriteLine("helloji");
        }
        internal void FinancialApp()
        {
            int[] transaction = { 200, -150, 340, 500, -100 };
            int sum = 0;
            for (int i = 0; i < transaction.Length; i++)
            {
                sum = sum + transaction[i];
            }
            Console.WriteLine(sum);
        }
        internal void AverageScore()
        {
            float[] score = { 85.5f, 90.3f, 78.4f, 88.9f, 92.1f };
            float sum = 0;
            for (int i = 0; i < score.Length; i++)
            {
                sum = sum + score[i];
            }
            float avg = sum / score.Length;
            Console.WriteLine(avg);
        }
        
    }
}
