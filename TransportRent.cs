using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howemork4
{
    public class TransportRent <T> where T : ITransport
    {
        public string FIO { get; set; }
        public T TransportType { get; set; }
        public double RentTime { get; set; }
        public double RentCost { get; set; }

        public string Info() => $"Транспорт: {TransportType}, время аренды: {RentTime}, ФИО клиента: {FIO}, Стоимость аренды: {RentTime * RentCost}";
    }
}
