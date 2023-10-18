using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Task_4
Создайте класс «Веб-сайт». Необходимо хранить в 
полях класса: название сайта, путь к сайту, описание 
сайта, ip адрес сайта. Реализуйте методы класса для ввода 
данных, вывода данных, реализуйте доступ к отдельным 
полям через методы класса.
 
 */
namespace DZ_3_C_Sharp_Multiplication__matrix_Structural__Features
{
    internal class Website
    {
        private string name;
        private string path;
        private string description;
        private string ipAddress;

        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetPath(string path)
        {
            this.path = path;
        }
        public void SetDescription(string description)
        {
            this.description = description;
        }

        public void SetIpAdress(string ipAdress)
        {
            this.ipAddress = ipAdress;
        }
        public string GetName()
        {
            return this.name;
        }
        public string GetPath()
        {
            return this.path;
        }
        public string GetDescription()
        {
            return this.description;
        }
        public string GetIpAddress()
        {
            return this.ipAddress;
        }

        public void Print()
        {
            Console.WriteLine($"Имя «Веб-сайт»: {name}");
            Console.WriteLine($"Путь «Веб-сайт»: {path}");
            Console.WriteLine($"Описание «Веб-сайт»: {description}");
            Console.WriteLine($"ip адрес «Веб-сайт»: {ipAddress}");
        }

    }
}
