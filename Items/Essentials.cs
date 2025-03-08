using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howemork4
{
    public class Essentials : ITax, Output
    {
        public string ClassName => _type;
        private static readonly string _type = "Предметы первой необходимости";

        public string ItemName { get; set; }
        public double ItemPrice { get; set; }

        public string AddTax() => $"Цена на товар: {ItemName} (с учетом налога) будет составлять: {ItemPrice + (ItemPrice * 0.5/100)}";

        public string Print() => $"{_type}, Название товара: {ItemName}, Цена без налога: {ItemPrice}, Цена с налогом: {ItemPrice + (ItemPrice * 0.5 / 100)}";
    }
}
