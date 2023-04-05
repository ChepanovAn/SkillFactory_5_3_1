using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_5_3_1
{
    class Program
    {
        static int ChangeAge(int age)
        {
            age = age + 1;           
            return age;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваш возраст");

            int age = Convert.ToInt32(Console.ReadLine());

            int Age = ChangeAge(age);

            Console.WriteLine(Age);

            Console.ReadKey();
        }
    }
}
