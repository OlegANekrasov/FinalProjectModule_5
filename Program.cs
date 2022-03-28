using System;

namespace FinalProjectModule_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowUserData(EnterUser());
            Console.ReadLine();
        }

        static (string firstName, string LastName, int Age, string[] NamePets, string[] FavoriteColorNames) EnterUser()
        {
            (string firstName, string LastName, int Age, string[] NamePets, string[] FavoriteColorNames) user;

            Console.WriteLine("Введите имя");
            user.firstName = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            user.LastName = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Введите возраст цифрами");
                if (CheckNum(Console.ReadLine(), out int cneckNum))
                {
                    user.Age = cneckNum;
                    break;
                }
                else
                {
                    Console.WriteLine("Необходимо ввести число больше 0");
                }
            }

            user.NamePets = null;
            Console.WriteLine("Если есть питомец, введите Да");
            if(Console.ReadLine().ToUpper() == "ДА")
            {
                while (true)
                {
                    Console.WriteLine("Введите количество питомцев цифрами");
                    if (CheckNum(Console.ReadLine(), out int cneckNum))
                    {
                        user.NamePets = new string[cneckNum];
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Количество питомцев должно быть число больше 0");
                    }
                }

                for(int i = 0; i < user.NamePets.Length; i++)
                {
                    Console.WriteLine("Введите кличку питомца");
                    user.NamePets[i] = Console.ReadLine();
                }
            }

            user.FavoriteColorNames = null;
            Console.WriteLine("Если есть любимые цвета, введите Да");
            if (Console.ReadLine().ToUpper() == "ДА")
            {
                while (true)
                {
                    Console.WriteLine("Введите количество любимых цветов");
                    if (CheckNum(Console.ReadLine(), out int cneckNum))
                    {
                        user.FavoriteColorNames = new string[cneckNum];
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Количество должно быть число больше 0");
                    }
                }

                for (int i = 0; i < user.FavoriteColorNames.Length; i++)
                {
                    Console.WriteLine("Введите любимый цвет");
                    user.FavoriteColorNames[i] = Console.ReadLine();
                }
            }
            return user;
        }

        static bool CheckNum(string str, out int cneckNum)
        {
            bool result = false;
            cneckNum = 0;
            if(int.TryParse(str, out int num))
            {
                cneckNum = num;
                if(cneckNum > 0)
                    result = true;
            }

            return result;
        }

        static void ShowUserData((string firstName, string LastName, int Age, string[] NamePets, string[] FavoriteColorNames) user)
        {
            Console.WriteLine("\nДанные полльзователя:");
            Console.WriteLine($"Имя : {user.firstName}");
            Console.WriteLine($"Фамилия : {user.LastName}");
            Console.WriteLine($"Возраст : {user.Age}");

            if(user.NamePets != null)
            {
                Console.WriteLine("\nПитомцы:");
                foreach (var namePet in user.NamePets)
                {
                    Console.WriteLine($"Кличка : {namePet}");
                }
            }

            if (user.FavoriteColorNames != null)
            {
                Console.WriteLine("\nСписок любимых цветовЗав:");
                foreach (var favoriteColorName in user.FavoriteColorNames)
                {
                    Console.WriteLine($"Любимый цвет : {favoriteColorName}");
                }
            }
        }
    }
}
