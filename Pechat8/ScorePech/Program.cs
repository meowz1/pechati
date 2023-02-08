using System;
using System.Diagnostics;

namespace ScorePech
{
    public class Program
    {
        public static bool start = false;

        static void Main(string[] argrs)
        {
            User user = new User();
            bool flag = false;
            Thread ts = new Thread(_ =>
            {
                while (true)
                {   
                    Stopwatch t = new Stopwatch();
                    
                    if (start == true)
                    {
                        t.Start();
                        while (true)
                            {
                                if (t.ElapsedMilliseconds / 1000 == 60)
                                {
                                    t.Stop();
                                    Console.WriteLine( $"\n Минута прошла!");
                                    start = false;
                                    break;
                                }
                            }
                    }
                    
                }
                
            });
            ts.Start();


            while (!flag)
            {
                Console.WriteLine("Ввведите имя для таблицы рекордов:");

                string name = Console.ReadLine();
                user.username = name;
                Console.Clear();
                start = true;
                user.sInMin =  PrintText.InpText();
                user.sInSec = user.sInMin / 60.0;

                string text = $"\n {user.username} {user.sInSec} {user.sInMin}";
                //ПОСАВИТЬ ПУТЬ ДО ТХТ
                File.AppendAllText("C:\\Users\\UName\\source\\repos\\ScorePech\\records.txt", text);
                //ПОСАВИТЬ ПУТЬ ДО ТХТ
                string records = File.ReadAllText("C:\\Users\\UName\\source\\repos\\ScorePech\\records.txt");
                Console.WriteLine("Таблица рекордов");
                Console.WriteLine(records);
                Console.WriteLine();
                
            }

        }


    }
}