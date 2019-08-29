using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7__Tanks_
{
    class Program
    {
        static void Main(string[] args)
        {
            int key;
            bool isGameActive = true;
            const int teamMembers = 5;
            Tank[] teamUSSR = new Tank[teamMembers];
            Tank[] teamGermany = new Tank[teamMembers];                       
            do
            {
                int UssrPoints = 0, GermanyPoints = 0;
                Console.Clear();
                Console.WriteLine("Добро пожаловать в танковые сражения! \n1. Инициализировать команды \n2. Просмотр список танков и их показателей" +
               "\n3. Провести танковый бой \n0. Выход");
                try
                {
                    key = int.Parse(Console.ReadLine());
                    switch (key)
                    {
                        case 1:
                            {
                                Console.Clear();
                                for (int i = 0; i < teamGermany.Length; i++)
                                {
                                    Console.WriteLine("Введите название танка " + (i + 1) + " команды СССР");// i +1 для удобства пользователя, чтобы отчет начинался не с 0 а с 1
                                    string tankName;
                                    tankName = Console.ReadLine();
                                    teamUSSR[i] = new Tank(tankName);
                                }

                                for (int i = 0; i < teamGermany.Length; i++)
                                {
                                    Console.WriteLine("Введите название танка " + (i + 1) + " команды Германия");
                                    string tankName;
                                    tankName = Console.ReadLine();
                                    teamGermany[i] = new Tank(tankName);
                                }
                            }
                            break;
                        case 2:
                            {
                                Console.Clear();
                                for (int i = 0; i < teamUSSR.Length; i++)
                                {
                                    Console.WriteLine(teamUSSR[i].TankName); Console.WriteLine(teamUSSR[i].ArmorLevel);
                                    Console.WriteLine(teamUSSR[i].BulletCount); Console.WriteLine(teamUSSR[i].MaxSpeed);
                                    Console.WriteLine("----------------------------------------------------------------");
                                }
                                for (int i = 0; i < teamGermany.Length; i++)
                                {
                                    Console.WriteLine(teamGermany[i].TankName); Console.WriteLine(teamGermany[i].ArmorLevel);
                                    Console.WriteLine(teamGermany[i].BulletCount); Console.WriteLine(teamGermany[i].MaxSpeed);
                                    Console.WriteLine("----------------------------------------------------------------");
                                }
                            }
                            break;
                        case 3:
                            Console.Clear();
                            for (int i = 0; i < teamMembers; i++)
                            {
                                if (teamUSSR[i] ^ teamGermany[i])
                                {
                                    UssrPoints++;
                                }
                                else if (teamGermany[i] ^ teamUSSR[i])
                                {
                                    GermanyPoints++;
                                }
                            }
                            if (UssrPoints > GermanyPoints)
                            {
                                Console.WriteLine("Со счетом " + UssrPoints + " - " + GermanyPoints + " победила команда СССР");
                            }
                            else if (GermanyPoints > UssrPoints)
                            {
                                Console.WriteLine("Со счетом " + GermanyPoints + " - " + UssrPoints + " победила команда немцев");
                            }
                            else if (GermanyPoints == UssrPoints)
                            {
                                Console.WriteLine("В данном бою зарегистрирована ничья");
                            }
                            break;
                        case 0:
                            isGameActive = false;
                            break;
                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("Неверная команда, для выбора комманды нужно ввести целое число!!!");
                }
                        Console.ReadLine();
            } while (isGameActive != false);
        }
    }
}
