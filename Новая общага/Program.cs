using System;
using System.Collections.Generic;
using System.Data;

namespace НоваяОбщага
{
    class Stud
    {
        public string fio;
        public string day;
        public string month;
        public string year;
        public string group;
        public string[] dis;
        public string[] oze;

        public Stud(string fio, string year, string month, string day, string group, string[] dis, string[] oze)
        {
            this.fio = fio;
            this.day = day;
            this.month = month;
            this.year = year;
            this.group = group;
            this.dis = dis;
            this.oze = oze;

        }
    }
    public class НоваяОбщага
    {
        public static void Main()
        {
            List<Stud> list = new List<Stud>();
            string a;
            int q = 0, Yt = 0;
            while (true)
            {
                Console.WriteLine(@"
1. Добавить студента в базу
2. Выввести студентов определённой группы
3. Вывести всех должников
4. Вывести всех отличников
5. Вывети всех студентов моложе 20 лет
6. Завершить работу программы");

                string num = Console.ReadLine();
                Console.Clear();
                if (num == "1")
                {
                    
                    Console.WriteLine("Введите фио");
                    string fio = Console.ReadLine();
                    Console.WriteLine("Введите день рождения");
                    string day = Console.ReadLine();
                    Console.WriteLine("Введите месяц рождения");
                    string month = Console.ReadLine();
                    Console.WriteLine("Введите год");
                    string year = Console.ReadLine();
                    Console.WriteLine("Введите группу");
                    string group = Console.ReadLine();
                    Console.WriteLine("Введите колличество прдметов");
                    Yt = Convert.ToInt32(Console.ReadLine());
                    string[] dis = new string[Yt];
                    string[] oze = new string[Yt];
                    for (int i = 0; i < Yt; i++)
                    {
                        Console.WriteLine("Введите название {0} предметa",i+1);
                        dis[i] = Console.ReadLine();
                        Console.WriteLine("Введите оценку по {0} предмету",i+1);
                        oze[i] = Console.ReadLine();
                        if (oze[i] == "") { oze[i] = "2"; }
                    }
                    list.Add(new Stud(fio, year, month, day, group, dis, oze));
                    q = 1;
                }
                else if (num == "2")
                {
                    Console.WriteLine("Введите группу");
                    a = Console.ReadLine();
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].group == a)
                        {
                            q++;
                            Console.WriteLine(list[i].fio);
                        }
                    }
                }
                else if (num == "3")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        for (int j = 0; j < list[i].oze.Length; j++)
                        {
                            if ((list[i].oze[j] == "")||(Convert.ToInt32(list[i].oze[j]) <=2))
                            {
                                q++;
                                Console.WriteLine(list[i].fio);
                            }
                        }
                    }
                }
                else if (num == "4")
                {
                    int count = 0;
                    for (int i = 0; i < list.Count; i++)
                    {
                        for (int j = 0; j < list[i].oze.Length; j++)
                        {
                            count = count + Convert.ToInt32(list[i].oze[j]);
                        }
                        if (count==list[i].oze.Length * 5)
                        {
                            q++;
                            Console.WriteLine(list[i].fio);
                        }
                    }
                }
                else if (num == "5")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (Convert.ToInt32(list[i].year) >= 2003)
                        {
                            q++;
                            Console.WriteLine(list[i].fio);
                        }
                    }
                }
                else if (num == "6")
                {
                    break;
                }
                if (q == 0) { Console.WriteLine("Данных не найдено"); }
                q = 0;
                Console.WriteLine("Для возврата в меню нажмите любую клавишу");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}