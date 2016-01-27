using System;
using System.Collections.Generic;

namespace Notebook
{
    class Program
    {
        static void Main(string[] args)
        {
            // объявим переменную в которой будут храниться наши записи
            List<String> notes = new List<string>();
            
            // добавим пару начальных записей
            notes.Add("Первая запись");
            notes.Add("Вторая запись");

            char action = 'h'; // переменная, которая будет хранить нажатую клавишу
            // мы указали символ h - который будет использоваться для вывода всех возмож-ных комманд от англ. help
            
            // цикл в котором будет проводится считываение нажатий клавиш и выполнение соответсвующий действий
            // цикл завершиться когда будет нажата клавиша q
            while (action != 'q')
            {
                // проверяем какая из клавишь была нажата
                switch (action)
                {
                    // вывести все записи
                    case 'l':
                        foreach (var note in notes)
                        {
                            Console.WriteLine((notes.IndexOf(note)+1) + ") " +note); // т.к. в списке нумерация начинается с 0, то прибавляем 1
                        }
                        break;
                    
    case 'h':
        Console.WriteLine("Доступные команды:");
        Console.WriteLine("a - добавить запись");
        Console.WriteLine("d - удалить запись с номером n");
        Console.WriteLine("l - список всех записей");
        Console.WriteLine("h - список доступных команд");
        Console.WriteLine("q - выйти из программы");
        break;

                    // добавить запись
                    case 'a':
                        Console.Write("Введите сообщение: ");
                        var newNote = Console.ReadLine(); // считываем сообщение
                        notes.Add(newNote); // добавляем сообщение в конец списка
                        break;

                    // удалить запись
                    case 'd':
                        Console.Write("Введите номер записи для удаления: ");
                        int n = Convert.ToInt32(Console.ReadLine())-1; // мы вычитаем 1 т.к. в списке нумерация начинается с 0
                        // проверим существует ли введеный номер записи
                        if (n <= notes.Count && n > -1)
                        {
                            notes.RemoveAt(n);
                        }
                        else
                        {
                            Console.WriteLine("Записи с указанным номером не существует");
                        }
                        break;
                    default:
                        Console.WriteLine("Неизвестная команда");
                        break;
                }
                Console.Write("Введите команду: ");
                action = Console.ReadKey().KeyChar; // считываем новое действие
                Console.WriteLine(); // для переноса вывода на новую строку
            }
        }
    }
}


