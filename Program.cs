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
                Console.WriteLine("Введите возраст");
                if (CheckNum(Console.ReadLine(), out int age))
                {
                    user.Age = age;
                    break;
                }
                else
                {
                    Console.WriteLine("Необходимо ввести число больше 0");
                }
            }


            user.NamePets = null;
            user.FavoriteColorNames = null;
            return user;
        }

        static bool CheckNum(string str, out int age)
        {
            bool result = false;
            age = 0;
            if(int.TryParse(str, out int num))
            {
                age = num;
                if(age > 0)
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
        }
    }
}
