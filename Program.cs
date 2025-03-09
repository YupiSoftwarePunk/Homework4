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
            string brand = Console.ReadLine();

            Console.Write("Введите модель: ");
            string model = Console.ReadLine();

            Console.Write("Введите год выпуска: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Введите цвет: ");
            string colour = Console.ReadLine();

            Console.Write("Введите вин-номер: ");
            string vinNum = Console.ReadLine();

            cars.Add(new Car(vinNum, brand, model, year, colour));

            Console.WriteLine("\n\nСписок автомобилей до удаления и сортировки:");
            foreach (var car in cars)
            {
                Console.WriteLine($"Марка: {car.Brand}, Модель: {car.Model}, VIN: {car.VinNum}, Цвет: {car.Colour}, Год: {car.Year}");
            }

            cars.Sort((car1, car2) => car1.Year.CompareTo(car2.Year));

            Console.Write("\n\n\nВведите VIN-номер для удаления: ");
            string vinToRemove = Console.ReadLine();

            int removedCount = cars.RemoveAll(car => car.VinNum == vinToRemove);

            if (removedCount > 0)
            {
                Console.WriteLine("\nАвтомобиль удален.");
            }
            else
            {
                Console.WriteLine("\nАвтомобиль с таким VIN-номером не найден.");
            }


            Console.WriteLine("\n\nСписок автомобилей после удаления и сортировки:");
            foreach (var car in cars)
            {
                Console.WriteLine($"Марка: {car.Brand}, Модель: {car.Model}, Вин-номер мотора: {car.VinNum}, Цвет: {car.Colour}, Год: {car.Year}");
            }
        }
    }
} 
