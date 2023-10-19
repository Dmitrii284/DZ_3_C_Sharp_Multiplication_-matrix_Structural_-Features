using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3_C_Sharp_Multiplication__matrix_Structural__Features
{
    internal class Shop
    {
        private string? name;
        private string? address;
        private string? description;
        private string? phone;
        private string? email;

        public void InputData()
        {
            Console.WriteLine("Введите название магазина:");
            name = Console.ReadLine();

            Console.WriteLine("Введите адрес магазина:");
            address = Console.ReadLine();

            Console.WriteLine("Введите описание магазина:");
            description = Console.ReadLine();

            Console.WriteLine("Введите контактный телефон:");
            phone = Console.ReadLine();

            Console.WriteLine("Введите контактный e-mail:");
            email = Console.ReadLine();
        }

        public void OutputData()
        {
            Console.WriteLine($"Название магазина: {name}");
            Console.WriteLine($"Адрес магазина: {address}");
            Console.WriteLine($"Описание магазина: {description}");
            Console.WriteLine($"Контактный телефон: {phone}");
            Console.WriteLine($"Контактный e-mail: {email}");
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string newName)
        {
            name = newName;
        }

        public string GetAddress()
        {
            return address;
        }

        public void SetAddress(string newAddress)
        {
            address = newAddress;
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetDescription(string newDescription)
        {
            description = newDescription;
        }

        public string GetPhone()
        {
            return phone;
        }

        public void SetPhone(string newPhone)
        {
            phone = newPhone;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string newEmail)
        {
            email = newEmail;
        }

    }
}
