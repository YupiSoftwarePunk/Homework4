using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howemork4
{
    public struct Car
    {
        public string VinNum { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }

        public string Info() => $"Марка машины: {Brand}, Модель: {Model}, Год выпуска: {Year}, Цвет: {Colour}, Вин-номер двигателя: {VinNum}";


        public string IsVinNumCorrect(string num)
        {
            if (num == VinNum)
            {
                return $"Номер {num} содержится в структуре";
            }
            else
            {
                return $"ERROR!! Номер {num} не содержится в структуре";
            }
        }

        public Car(string vinNum, string brand, string model, int year, string colour)
        {
            this.VinNum = vinNum;
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.Colour = colour;
        }
    }
}
