﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorePech
{
    internal static class PrintText
    {
        //ПОСАВИТЬ ПУТЬ ДО ТХТ
        static string text = File.ReadAllText("C:\\Users\\Uname\\source\\repos\\ProjName\\text.txt");
        static char[] chars = text.ToCharArray();

        static public int InpText()
        {
            int ind = 0;
            List<int> count = new List<int>();
            while (Program.start)
            {
                for (int i = 0; i < chars.Length; i++)
                {
                    if (count.Contains(i))
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(chars[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(chars[i]);
                    }
                }
                ConsoleKeyInfo key = Console.ReadKey();


                if (key.KeyChar.ToString().ToLower() == chars[ind].ToString().ToLower())
                {
                    count.Add(ind);
                    ind++;

                }
                Console.Clear();

            }
            return count.Count;
        }

    }
}
