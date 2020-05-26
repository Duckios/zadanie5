using System;
using static System.Console;
using static System.Convert;
using System.Collections;
using System.Collections.Generic;

          /*int ids = ToInt32(ReadLine());
            parametrs.Add(ids);
            string fio = ReadLine();
            parametrs.Add(fio);
            int group = ToInt32(ReadLine());
            parametrs.Add(group);
            int data = ToInt32(ReadLine());
            parametrs.Add(data);*/
namespace pract5
{
    
    class Program
    {
        class Lib
        {
            public class Student
            {
                public int ids;
                public string fio;
                public int group;
                public string data;
            }
            public List<Student> stud= new List<Student>();

            public void addstud(int ids, string fio, int group, string data)
            {
                stud.Add(new Student() { ids = ids, fio = fio, group = group, data = data }) ;
            }
            public void del(int ids)
            {
                for (int i = 0; i < stud.Count; i++)
                {
                    if (stud[i].ids == ids) stud.RemoveAt(i); 
                }
            }
            public void izmen(int ids, string fio, int group, string data)
            {
                for (int i = 0; i < stud.Count; i++)
                {
                    if (stud[i].ids == ids)
                    {
                        stud[i].fio = fio;
                        stud[i].group = group;
                        stud[i].data = data;
                    }
                    
                }
            }
            public void show()
            {
                foreach (var i in stud)
                {
                    Console.WriteLine(i.ids + "\n" + i.fio + "\n" + i.group + "\n" + i.data);
                }
            }
        }
        static void Main(string[] args)
        {
            Lib L = new Lib();
            int ids=0;
            int z;
            do
            {
                WriteLine("Введите индекс студента: ");
                z = ToInt32(ReadLine());
                if (z == 1)
                {
                    //Добавить
                    WriteLine("Введите Ф.И.О. студента: ");
                    string fio = ReadLine();
                    WriteLine("Введите группу студента: ");
                    int group = ToInt32(ReadLine());
                    WriteLine("Введите дату рождения студента (дд.мм.гггг): ");
                    string data = ReadLine();
                    L.addstud(ids, fio, group, data);
                    ids++;
                }
                else if (z == 2)
                {
                    //Изменить
                    int idsT = ToInt32(ReadLine());
                    string fio = ReadLine();
                    int group = ToInt32(ReadLine());
                    string data = ReadLine();
                    L.izmen(idsT, fio, group, data);
                }
                else if (z == 3)
                {
                    //Удалить
                    ids = ToInt32(ReadLine());
                    L.del(ids);
                }
                else if (z==4) L.show(); //Показать

            } while (z != 0) ;


        }
    }
}
