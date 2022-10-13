using System;

namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
            int x = 0;
            for(int i = 0; i < strings.Length; i++)
            {
                if(strings[i].Length == 4)
                {
                    x++;
                }
                
            }

           int y = 0;
            string[] strings2 = new string[x];
            for(int j = 0; j < strings.Length; j++)
            {
                if(strings[j].Length == 4)
                {
                    strings2[y] = strings[j]; 
                    y++;
                }
                
            }
            return strings2;
        }
    }
}
