using BDLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using пр5модули.Models;

namespace пр5модули
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HospitalProEntities db = Helper.GetContext();
            Class1 class1 = new Class1();
            Patient patient1 = new Patient();

            string firstname = null;
            string secondname = null;
            string login = null;
            string password = null;

            while (firstname == null) {
                Console.WriteLine("Введите имя нового пользователя");
                firstname = Console.ReadLine();
                patient1.firstname = firstname;
            }
            while (secondname == null)
            {
                Console.WriteLine("Введите фамилию нового пользователя");
                secondname = Console.ReadLine();
                patient1.secondname = secondname;
            }
            while (login == null)
            {
                Console.WriteLine("Введите логин нового пользователя");
                login = Console.ReadLine();
                patient1.login = login;
            }
            while (password == null)
            {
                Console.WriteLine("Введите пароль нового пользователя");
                password = Console.ReadLine();
                patient1.password = password;
            }
            string hashPass = class1.HashPassword(password);
            patient1.password = hashPass;

            Helper helper = new Helper();
            helper.CreatePatient(patient1);
        }
    }
}
