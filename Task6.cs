﻿using System;
namespace Tasks.Task6
{

    public class Task06
    {
        int magicNumber = 64;    
        public int TitleToNumber(string columnTitle)
        {
            int sum = 0;
            int TitleLenght = columnTitle.Length;
            int j = TitleLenght-1;
            foreach (char letter in columnTitle)
            {
                int position = j;
                int positionWeight= (int)Math.Pow(26,j);
                int letterValue = Convert.ToInt32(letter) - magicNumber;  // A = 1 
                int positionletterWeight = positionWeight * letterValue;
                j--;
                sum += positionletterWeight;
            }
            return sum;
        }

    }
}
