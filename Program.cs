using System;

class Program
{
    
    delegate void MenuPunkt();

    static void Main(string[] args)
    {
        MenuPunkt[] punkt = new MenuPunkt[5];
        punkt[0] = NewGame;
        punkt[1] = LoadGame;
        punkt[2] = ShowRules;
        punkt[3] = ShowAbout;
        punkt[4] = Exit;

        while (true)
        {
            ShowMenu();

            int choice = GetUserChoice();

            if (choice >= 0 && choice <= 4)
            {
                punkt[choice]();
            }
            else
            {
                Console.WriteLine("Неверно! Пробуйте заново");
            }
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("Меню:");
        Console.WriteLine("1 - Новая игра");
        Console.WriteLine("2 - Загрузить игру");
        Console.WriteLine("3 - Правила");
        Console.WriteLine("4 - Об авторе");
        Console.WriteLine("0 - Выход");
    }

    static int GetUserChoice()
    {
        Console.Write("Выберите пункт меню (введите число): ");
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Ошибка ввода!");
            Console.Write("Выберите пункт меню (введите число): ");
        }
        return choice;
    }

    static void NewGame()
    {
        Console.WriteLine("Новая игра...");
    }

    static void LoadGame()
    {
        Console.WriteLine("Загрузка игры...");
    }

    static void ShowRules()
    {
        Console.WriteLine("Правила:");
    }

    static void ShowAbout()
    {
        Console.WriteLine("Об авторе:");
    }

    static void Exit()
    {
        Console.WriteLine("Выход");
        Environment.Exit(0); 
    }
}
