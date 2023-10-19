using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Task_5
 Создайте класс «Журнал». Необходимо хранить в 
полях класса: название журнала, год основания, описание журнала, контактный телефон, контактный e-mail. 
Реализуйте методы класса для ввода данных, вывода 
данных, реализуйте доступ к отдельным полям через 
методы класса. 
 */
namespace DZ_3_C_Sharp_Multiplication__matrix_Structural__Features
{
    internal class Journal
    {
        private string? name;
        private DateOnly dateOnly;
        private string? descript;
        private string? telNum;
        private string? e_maill;


#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public Journal(string name, DateOnly dateOnly, string? descript, string? telNum, string? e_maill)
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        {
            this.name = name;
            this.dateOnly = dateOnly;
            this.descript = descript;
            this.telNum = telNum;
            this.e_maill = e_maill;
        }

        public Journal() { }

        public void Print()
        {
            Console.WriteLine($"Название журнала:  {name}");
            Console.WriteLine($"Год основания: {dateOnly}");
            Console.WriteLine($"Описание журнала: {descript}");
            Console.WriteLine($"Контактный телефон: {telNum}");
            Console.WriteLine($"Контактный email: {e_maill}");
        }
#pragma warning disable CS8618
        public string GetName() { return name; }
        public DateOnly DateOnly() { return dateOnly; }
        public string GetDescript() { return descript; }
        public string GetTelNum() { return telNum; }
        public string GetE_maill() { return e_maill; }
#pragma warning restore CS8618

        public void SetName(string name) { this.name = name; }
        public void SetDescription(string descript) { this.descript = descript; }
        public void SetDate(DateOnly dateOnly) { this.dateOnly = dateOnly; }
        public void SetTelNum(string teelNum) { this.telNum = teelNum; }
        public void SetE_maill(string e_maill) { this.e_maill = e_maill; }

    }
}
