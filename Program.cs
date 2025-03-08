namespace Howemork4
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            cars.Add(new Car("12df34", "Toyata", "Mark II", 1999, "Orange"));
            cars.Add(new Car("22we344", "BMW", "M5", 2020, "White"));
            cars.Add(new Car("349clmd79", "Porche", "911", 2024, "Yellow"));
            cars.Add(new Car("678gjhg47", "Honda", "Civic", 1990, "Blue"));
            cars.Add(new Car("974gf6", "Lincoln", "Continental", 1970, "Black"));


            Console.WriteLine("Добавьте новую машину: ");

            Console.Write("Введите марку: ");
            string brand = Convert.ToString(Console.Read());

            Console.Write("Введите модель: ");
            string model = Convert.ToString(Console.Read());

            Console.Write("Введите год выпуска: ");
            int year = (int)Convert.ToInt64(Console.Read());

            Console.Write("Введите цвет: ");
            string colour = Convert.ToString(Console.Read());

            Console.Write("Введите вин-номер: ");
            string vinNum = Convert.ToString(Console.Read());

            cars.Add(new Car(vinNum, brand, model, year, colour));

            foreach (var i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
