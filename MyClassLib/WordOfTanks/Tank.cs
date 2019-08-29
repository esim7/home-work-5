using System;

namespace Day7__Tanks_
{
    public class Tank
    {
        //Решил сделать статическое поле для генерации случайных значений параметров танка
        //иначе если назначать в значения полей в конструкторе будут одинаковые параметры у всех такнов.
        //Можно было бы сделать задержку по времени но мне показалось что это костыль
        private static Random random;

        private string _tankName;
        private int _bulletCount;
        private int _armorLevel;
        private int _maxSpeed;

        static Tank()
        {
            random = new Random();
        }

        public Tank(string tankName)
        {

            TankName = tankName;
            BulletCount = random.Next(50, 100);
            ArmorLevel = random.Next(50, 100);
            MaxSpeed = random.Next(40, 60);
        }

        public string TankName
        {
            get
            {
                return _tankName;
            }
            set
            {
                _tankName = value;
            }
        }

        public int BulletCount
        {
            get
            {
                return _bulletCount;
            }
            set
            {
                _bulletCount = value;
            }
        }

        public int ArmorLevel
        {
            get
            {
                return _armorLevel;
            }
            set
            {
                _armorLevel = value;
            }
        }

        public int MaxSpeed
        {
            get
            {
                return _maxSpeed;
            }
            set
            {
                _maxSpeed = value;
            }
        }

        public static bool operator ^(Tank objLeft, Tank objRight)
        {
            if((objLeft.BulletCount > objRight.BulletCount && objLeft.ArmorLevel> objRight.ArmorLevel) || 
                (objLeft.ArmorLevel > objRight.ArmorLevel && objLeft.MaxSpeed > objRight.MaxSpeed) ||
                (objLeft.MaxSpeed > objRight.MaxSpeed && objLeft.BulletCount > objRight.BulletCount))
            {
                return true;
            }
            return false;
        }
    }
}
